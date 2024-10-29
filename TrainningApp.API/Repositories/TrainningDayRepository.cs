using FluentResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;
using TrainningApp.Infrastructure.Data;

namespace TrainningApp.Infrastructure.Repositories
{
    public class TrainningDayRepository : ITrainningDayRepository
    {
        private readonly ApplicationDbContext _db;

        public TrainningDayRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Result> CreateAsync(TrainningDay model)
        {
            _db.TrainningDays.Add(model);
            _db.SaveChangesAsync();

            return Result.Ok().WithSuccess(model.Id.ToString());
        }

        public async Task<Result> DeleteAsync(TrainningDay model)
        {
            TrainningDay trainningDay = await _db.TrainningDays.Where(x => x.DisabledAt == null && x.Id == model.Id).FirstOrDefaultAsync();

            trainningDay.DisabledAt = DateTime.Now;
            _db.SaveChangesAsync();

            return Result.Ok();
        }

        public async Task<List<TrainningDay>> FindAllTrainningIdAsync(int trainningId)
        {
            List<TrainningDay> trainningDays = await _db.TrainningDays.Where(x => x.Trainning.Id == trainningId && x.DisabledAt == null)
                .OrderBy(x => x.Name)
                .ToListAsync();

            return trainningDays;
        }

        public async Task<TrainningDay> FindByIdAsync(int id)
        {
            TrainningDay trainningDay = await _db.TrainningDays.Where(x => x.DisabledAt == null && x.Id == id)
                .Include(x =>x.Trainning)
                .ThenInclude(x => x.Users)
                .Include(x => x.TrainningExercises)
                .FirstOrDefaultAsync();

            return trainningDay;
        }

        public async Task<Result> UpdateAsync(TrainningDay model)
        {
            TrainningDay trainningDay = await _db.TrainningDays.Where(x => x.DisabledAt == null && x.Id == model.Id).FirstOrDefaultAsync();
            trainningDay.UpdatedAt = DateTime.Now;
            trainningDay.Name = model.Name;
            trainningDay.TrainningExercises = model.TrainningExercises.ToList();

            _db.SaveChangesAsync();

            return Result.Ok();
        }
    }
}
