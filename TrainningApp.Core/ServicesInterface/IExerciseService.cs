using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO.Exercise;
using TrainningApp.Core.DTO.TrainningDay;

namespace TrainningApp.Core.ServicesInterface
{
    public interface IExerciseService
    {
        public Task<Result> SaveAsync(ExerciseVO model, string idUser);
        public Task<Result> DeleteAsync(int exerciseId, string idUser);
        public Task<ExerciseVO> FindByIdAsync(int id, string idUser);
    }
}
