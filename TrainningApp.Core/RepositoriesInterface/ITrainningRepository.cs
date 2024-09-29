using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;


namespace TrainningApp.Core.RepositoriesInterface
{
    public interface ITrainningRepository
    {
        public Task<Result> CreateAsync(Trainning model);
        public Task<Result> UpdateAsync(Trainning model);
        public Task<Result> DeleteAsync(Trainning model);
        public Task<Trainning> FindByIdAsync(int id);
        public Task<List<Trainning>> FindAllAsync();
        public Task<List<Trainning>> FindAllByIdPersonalAsync(string idPersonal);

    }
}
