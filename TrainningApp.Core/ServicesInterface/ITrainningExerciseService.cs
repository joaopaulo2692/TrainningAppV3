using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO;
using TrainningApp.Core.DTO.TrainningExercise;

namespace TrainningApp.Core.ServicesInterface
{
    public interface ITrainningExerciseService
    {
        public Task<Result> SaveAsync(TrainningExerciseVO model, string idUser);
        public Task<Result> RemoveAsync(int trainningExerciseId, string idUser);
        public Task<TrainningExerciseVO> GetByIdAsync(string idUser, int trainningExercise);
        public Task<List<TrainningExerciseVO>> GetAllByTrainningDay(string idUser, int trainningDayId);
   
    }
}
