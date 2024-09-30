using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO.TrainningDay;
using TrainningApp.Core.Entities;

namespace TrainningApp.Core.ServicesInterface
{
    public interface ITrainningDayService
    {
        public Task<Result> SaveAsync(TrainningDayVO model, string idUser);
        public Task<Result> DeleteAsync(int trainningDayId, string idUser);
        public Task<TrainningDayVO> FindByIdAsync(int id, string idUser);
        public Task<List<TrainningDayVO>> FindAllTrainningIdAsync(int trainningId, string idUser);
    }
}
