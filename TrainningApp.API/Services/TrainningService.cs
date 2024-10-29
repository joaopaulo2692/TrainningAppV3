using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Constants;
using TrainningApp.Core.DTO;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;
using TrainningApp.Core.ServicesInterface;

namespace TrainningApp.Infrastructure.Services
{
    public class TrainningService : ITrainningService
    {
        private readonly ITrainningRepository _trainningRepo;
        private readonly IApplicationUserRepository _userRepository;
        private readonly IMapper _mapper;

        public TrainningService(ITrainningRepository trainningRepo, IApplicationUserRepository userRepository, IMapper mapper)
        {
            _trainningRepo = trainningRepo;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<List<TrainningVO>> GetAllAsync(string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);
            if (user == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            if (!user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotAdmManagement);
            }

            List<Trainning> trainningsList = await _trainningRepo.FindAllAsync();
            List<TrainningVO> trainningVOs = _mapper.Map<List<TrainningVO>>(trainningsList);

            return trainningVOs;
        }

        public async Task<List<TrainningVO>> GetAllByIdPersonalAsync(string idPersonal)
        {
            ApplicationUser userPersonal = await _userRepository.GetById(idPersonal);
            if (userPersonal == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            if (!userPersonal.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                if (!userPersonal.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Personal))
                {
                    throw new Exception(ConstantsMessageManagement.ErrorNotPersonalManagement);
                }
            }
          

            List<Trainning> trainningsList = await _trainningRepo.FindAllByIdPersonalAsync(idPersonal);
            List<TrainningVO> trainningVOs = _mapper.Map<List<TrainningVO>>(trainningsList);

            return trainningVOs;
        }

        public async Task<TrainningVO> GetByIdAsync(int id, string idUser)
        {
            ApplicationUser userPersonal = await _userRepository.GetById(idUser);
            if (userPersonal == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            Trainning trainning = await _trainningRepo.FindByIdAsync(id);
            if(trainning == null) throw new Exception(ConstantsMessageTrainning.ErrorGetById);

            TrainningVO trainningVO = _mapper.Map<TrainningVO>(trainning);

            return trainningVO;
        }

        public async Task<TrainningVO> GetByIdUserAsync(string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);
            if (user == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            Trainning trainning = await _trainningRepo.FindByIdUserAsync(idUser);
            if (trainning == null) throw new Exception(ConstantsMessageTrainning.ErrorUserWithoutTrainning);


            if (!user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                if (!user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Student))
                {
                    //if(trainning.PersonalId != idUser) throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
                    throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
                }
            }

            

            TrainningVO trainningVO = _mapper.Map<TrainningVO>(trainning);

            return trainningVO;
        }

        public async Task<Result> RemoveAsync(int trainningId, string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);
            if (user == null) return Result.Fail(ConstantsMessageApplicationUser.ErrorGetById);

            Trainning trainning = await _trainningRepo.FindByIdAsync(trainningId);
            if (trainning == null) throw new Exception(ConstantsMessageTrainning.ErrorGetById);

            if (!user.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                //if(trainning.Personal != user)
                //{
                //    return Result.Fail(ConstantsMessageManagement.ErrorNotAllowedManagement);
                //}                   
            }

            Result response = await _trainningRepo.DeleteAsync(trainning);

            return response;
        }

        public async Task<Result> SaveAsync(TrainningVO model, string idUser)
        {
            ApplicationUser personal = await _userRepository.GetById(idUser);
            List<ApplicationUser> users = new List<ApplicationUser>();

            if (personal == null) return Result.Fail(ConstantsMessageApplicationUser.ErrorGetById);
            foreach (string id in model.UsersId)
            {
                ApplicationUser user = await _userRepository.GetById(id);
                if (personal == null) return Result.Fail(ConstantsMessageApplicationUser.ErrorGetById);
                users.Add(user);

            }
           

            if (!personal.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Personal))
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotPersonalManagement);
            }
            Result response = new Result();
            if (model.Id == 0)
            {
                Trainning newTrainning = new Trainning()
                {
                    Goal = model.Goal,
                    Users = users,
                    FirstDay = model.FirstDay,
                    LastDay = model.LastDay
                };

                response = await _trainningRepo.CreateAsync(newTrainning);
                if (response.IsFailed) return Result.Fail(ConstantsMessageTrainning.ErrorCreate);

                return response;
            }

            Trainning trainning = await _trainningRepo.FindByIdAsync(model.Id);
            if (trainning == null) throw new Exception(ConstantsMessageTrainning.ErrorGetById);

            if (!personal.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Adm))
            {
                //if (trainning.Personal != user)
                //{
                //    return Result.Fail(ConstantsMessageManagement.ErrorNotAllowedManagement);
                //}
            }

            response = await _trainningRepo.UpdateAsync(trainning);
            return response;

        }
    }
}
