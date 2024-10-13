using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Constants;
using TrainningApp.Core.DTO;
using TrainningApp.Core.DTO.TrainningDay;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;
using TrainningApp.Core.ServicesInterface;

namespace TrainningApp.Infrastructure.Services
{
    public class TrainningDayService : ITrainningDayService
    {
        private readonly ITrainningDayRepository _trainningDayRepo;
        private readonly IApplicationUserRepository _userRepository;
        private readonly ITrainningRepository _trainingRepo;
        private readonly IMapper _mapper;
        private readonly ITrainningExerciseRepository _trainningExerciseRepo;


        public TrainningDayService(ITrainningDayRepository trainningDayRepo, IApplicationUserRepository userRepository, ITrainningRepository trainingRepo, IMapper mapper, ITrainningExerciseRepository trainningExerciseRepo)
        {
            _trainningDayRepo = trainningDayRepo;
            _userRepository = userRepository;
            _trainingRepo = trainingRepo;
            _mapper = mapper;
            _trainningExerciseRepo = trainningExerciseRepo;
        }

        public async Task<Result> SaveAsync(TrainningDayVO model, string idUser)
        {
            Result response = new Result();
            ApplicationUser userPersonal = await _userRepository.GetById(idUser);
            if (userPersonal == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            if (!userPersonal.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Personal))
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotPersonalManagement);
            }
            
            Trainning trainning = await _trainingRepo.FindByIdAsync(model.TrainningId);
            if (trainning == null) throw new Exception(ConstantsMessageTrainning.ErrorGetById);

            if(model.Id == 0)
            {
                TrainningDay trainningDay = new TrainningDay()
                {
                    Name = model.Name
                };

                response = await _trainningDayRepo.CreateAsync(trainningDay);
                return response;
                
            }
            else
            {
                List<TrainningExercise> trainningExercises = await _trainningExerciseRepo.FindByIdsAsync(model.TrainningExercisesId);
                TrainningDay trainningDay = new TrainningDay()
                {
                    Name = model.Name,
                    TrainningExercises = trainningExercises
                };
                response = await _trainningDayRepo.UpdateAsync(trainningDay);
                return response;
            }


        }

        public async Task<Result> DeleteAsync(int trainningDayId, string idUser)
        {
            Result response = new Result();
            ApplicationUser userPersonal = await _userRepository.GetById(idUser);
            if (userPersonal == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            if (!userPersonal.Managements.Select(x => x.Name).Contains(ConstantsMessageManagement.Personal))
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotPersonalManagement);
            }
            TrainningDay trainningDay = await _trainningDayRepo.FindByIdAsync(trainningDayId);
            if(trainningDay == null)
            {
                throw new Exception(ConstantsMessageTrainningDay.ErrorGetById);
            }
            if(trainningDay.Trainning.Personal != userPersonal)
            {
                throw new Exception(ConstantsMessageTrainning.ErrorTrainningNotByPersonal);
            }

            response = await _trainningDayRepo.DeleteAsync(trainningDay);
            return response;

        }

        public async Task<List<TrainningDayVO>> FindAllByTrainningIdIdAsync(int trainningId, string idUser)
        {

            ApplicationUser user = await _userRepository.GetById(idUser);
            if (user == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            Trainning trainning = await _trainingRepo.FindByIdAsync(trainningId);
            if (trainning == null) throw new Exception(ConstantsMessageTrainning.ErrorGetById);

            if (!user.Trainnings.Contains(trainning))
            {
                throw new Exception(ConstantsMessageTrainning.ErrorTrainningNotByUser);
            }

            List<TrainningDay> trainningDays = await _trainningDayRepo.FindAllTrainningIdAsync(trainningId);

            List<TrainningDayVO> trainningDaysVO = _mapper.Map<List<TrainningDayVO>>(trainningDays);

            return trainningDaysVO;
        }

        public async Task<TrainningDayVO> FindByIdAsync(int id, string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);
            if (user == null) throw new Exception(ConstantsMessageApplicationUser.ErrorGetById);

            TrainningDay trainningDay = await _trainningDayRepo.FindByIdAsync(id);
            if(trainningDay == null)
            {
                throw new Exception(ConstantsMessageTrainningDay.ErrorGetById);
            }

            Trainning trainning = await _trainingRepo.FindByIdAsync(trainningDay.Trainning.Id);
            if (trainning == null) throw new Exception(ConstantsMessageTrainning.ErrorGetById);

            if (!user.Trainnings.Contains(trainning))
            {
                throw new Exception(ConstantsMessageTrainning.ErrorTrainningNotByUser);
            }


            TrainningDayVO trainningDaysVO = _mapper.Map<TrainningDayVO>(trainningDay);

            return trainningDaysVO;
        }

     
    }
}
