using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.RepositoriesInterface
{
    public interface IExerciseRepository
    {
        public Task<Result> CreateAsync(Exercise exercise);
        public Task<Result> UpdateAsync(Exercise exercise);
        public Task<Result> DeleteAsync(Exercise exercise);
        public Task<Exercise> FindByIdAsync(int id);
        public Task<List<Exercise>> FindAllAsync();
    }
}
