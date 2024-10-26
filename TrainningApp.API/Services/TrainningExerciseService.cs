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
using TrainningApp.Core.DTO.TrainningExercise;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;
using TrainningApp.Core.ServicesInterface;

namespace TrainningApp.Infrastructure.Services
{
    public class TrainningExerciseService : ITrainningExerciseService
    {
        private readonly ITrainningExerciseRepository _trainningExerciseRepo;
        private readonly IMapper _mapper;
        private readonly ITrainningDayRepository _trainningDayRepo;
        private readonly IApplicationUserRepository _userRepository;

        public TrainningExerciseService(ITrainningExerciseRepository trainningExerciseRepo, IMapper mapper, ITrainningDayRepository trainningDayRepo, IApplicationUserRepository userRepository)
        {
            _trainningExerciseRepo = trainningExerciseRepo;
            _mapper = mapper;
            _trainningDayRepo = trainningDayRepo;
            _userRepository = userRepository;
        }

        public async Task<List<TrainningExerciseVO>> GetAllByTrainningDay(string idUser, int trainningDayId)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);

            TrainningDay trainningDay = await _trainningDayRepo.FindByIdAsync(trainningDayId);
            if(trainningDay == null) throw new Exception(ConstantsMessageTrainningDay.ErrorGetById);

            if(!trainningDay.Trainning.Users.Contains(user) && trainningDay.Trainning.Personal != user)
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
            }

            List<TrainningExercise> trainningExercises = trainningDay.TrainningExercises;

            List<TrainningExerciseVO> trainningExercisesVO = _mapper.Map<List<TrainningExerciseVO>>(trainningExercises);

            return trainningExercisesVO;
        }

        public async Task<TrainningExerciseVO> GetByIdAsync(string idUser, int trainningExerciseId)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);

            TrainningExercise trainningExercise = await _trainningExerciseRepo.FindByIdAsync(trainningExerciseId);
            if (trainningExercise == null) throw new Exception(ConstantsMessageTrainningExercise.ErroFindById);

            TrainningDay trainningDay = await _trainningDayRepo.FindByIdAsync(trainningExercise.TrainningDayId);
            if (trainningDay == null) throw new Exception(ConstantsMessageTrainningDay.ErrorGetById);

            if (!trainningDay.Trainning.Users.Contains(user) && trainningDay.Trainning.Personal != user)
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
            }

            TrainningExerciseVO trainningExercisesVO = _mapper.Map<TrainningExerciseVO>(trainningExercise);

            return trainningExercisesVO;
        }

        public async Task<Result> RemoveAsync(int trainningExerciseId, string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);

            TrainningExercise trainningExercise = await _trainningExerciseRepo.FindByIdAsync(trainningExerciseId);
            if (trainningExercise == null) throw new Exception(ConstantsMessageTrainningExercise.ErroFindById);

            TrainningDay trainningDay = await _trainningDayRepo.FindByIdAsync(trainningExercise.TrainningDayId);
            if (trainningDay == null) throw new Exception(ConstantsMessageTrainningDay.ErrorGetById);

            if (!trainningDay.Trainning.Users.Contains(user) && trainningDay.Trainning.Personal != user)
            {
                throw new Exception(ConstantsMessageManagement.ErrorNotAllowedManagement);
            }

            Result response = await _trainningDayRepo.CreateAsync(trainningDay);

            return response;
        }

        public async Task<Result> SaveAsync(TrainningExerciseVO model, string idUser)
        {
            ApplicationUser user = await _userRepository.GetById(idUser);
            Result response = new Result();
            TrainningDay trainningDay = await _trainningDayRepo.FindByIdAsync(model.TrainningDayId);
            if (trainningDay == null) throw new Exception(ConstantsMessageTrainningDay.ErrorGetById);

            TrainningExercise trainningExercise = _mapper.Map<TrainningExercise>(model);

            if(model.Id == 0)
            {
                response = await _trainningExerciseRepo.CreateAsync(trainningExercise);
                return response;
            }
            TrainningExercise trainningExerciseDb = await _trainningExerciseRepo.FindByIdAsync(model.Id);

            if (trainningExerciseDb == null) throw new Exception(ConstantsMessageTrainningExercise.ErroFindById);

            response = await _trainningExerciseRepo.UpdateAsync(trainningExercise);

            return response;

        }
    }
}
