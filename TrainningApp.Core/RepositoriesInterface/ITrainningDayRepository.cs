using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.RepositoriesInterface
{
     public interface ITrainningDayRepository
    {
        public Task<Result> CreateAsync(TrainningDay model);
        public Task<Result> UpdateAsync(TrainningDay model);
        public Task<Result> DeleteAsync(TrainningDay model);
        public Task<TrainningDay> FindByIdAsync(int id);
        public Task<List<TrainningDay>> FindAllTrainningIdAsync(int trainningId);
    }
}
