using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.ServicesInterface
{
    public interface ITrainningService
    {
        public Task<Result> SaveAsync(TrainningVO model, string idUser);
        public Task<Result> RemoveAsync(TrainningVO model);
        public Task<TrainningVO> GetByIdAsync(int id);
        public Task<List<TrainningVO>> GetAllAsync();
    }
}
