using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;

namespace TrainningApp.Infrastructure.Repositories
{
    public class TrainningExerciseRepository : ITrainningExerciseRepository
    {
        public Task<Result> CreateAsync(TrainningExercise trainningExercise)
        {
            throw new NotImplementedException();
        }

        public Task<Result> DeleteAsync(TrainningExercise trainningExercise)
        {
            throw new NotImplementedException();
        }

        public Task<TrainningExercise> FindByIdAsync(int trainningExerciseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<TrainningExercise>> FindByIdsAsync(List<int> trainningExerciseIds)
        {
            throw new NotImplementedException();
        }

        public Task<Result> UpdateAsync(TrainningExercise trainningExercise)
        {
            throw new NotImplementedException();
        }
    }
}
