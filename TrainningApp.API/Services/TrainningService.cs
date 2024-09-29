using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public TrainningService(ITrainningRepository trainningRepo, IApplicationUserRepository userRepository)
        {
            _trainningRepo = trainningRepo;
            _userRepository = userRepository;
        }

        public Task<List<TrainningVO>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TrainningVO> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result> RemoveAsync(TrainningVO model, string idUser)
        {
            throw new NotImplementedException();
        }

        public async Task<Result> SaveAsync(TrainningVO model, string idUser)
        {
            ApplicationUser userPersonal = await _userRepository.GetById(idUser);
            if(userPersonal == null) return Result.Fail("Erro");


            Trainning newTrainning = new Trainning()
            {
                Goal = model.Goal,
                Personal = userPersonal,
                FirstDay = model.FirstDay,
                LastDay = model.LastDay
            };

            Result response = await _trainningRepo.CreateAsync(newTrainning);
            if (response.IsFailed) return Result.Fail("Erro");

            return response;

        }
    }
}
