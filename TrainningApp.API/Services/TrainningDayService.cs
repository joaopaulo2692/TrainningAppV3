using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Constants;
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

        public TrainningDayService(ITrainningDayRepository trainningDayRepo, IApplicationUserRepository userRepository, ITrainningRepository trainingRepo, IMapper mapper)
        {
            _trainningDayRepo = trainningDayRepo;
            _userRepository = userRepository;
            _trainingRepo = trainingRepo;
            _mapper = mapper;
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
                
            }


        }

        public Task<Result> DeleteAsync(int trainningDayId, string idUser)
        {
            throw new NotImplementedException();
        }

        public Task<List<TrainningDayVO>> FindAllTrainningIdAsync(int trainningId, string idUser)
        {
            throw new NotImplementedException();
        }

        public Task<TrainningDayVO> FindByIdAsync(int id, string idUser)
        {
            throw new NotImplementedException();
        }

     
    }
}
