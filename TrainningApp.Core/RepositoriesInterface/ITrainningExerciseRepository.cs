using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.RepositoriesInterface
{
    public interface ITrainningExerciseRepository
    {
        public Task<List<TrainningExercise>> FindByIdsAsync(List<int> trainningExerciseIds);
        public Task<TrainningExercise> FindByIdAsync(int trainningExerciseId);
        public Task<Result> UpdateAsync(TrainningExercise trainningExercise);
        public Task<Result> CreateAsync(TrainningExercise trainningExercise);
        public Task<Result> DeleteAsync(TrainningExercise trainningExercise);
    }
}
