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
    public class TrainningRepository : ITrainningRepository
    {
        private readonly ApplicationDbContext _db;

        public TrainningRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Result> CreateAsync(Trainning model)
        {
            model.CreatedAt = DateTime.Now;
            model.UpdatedAt = DateTime.Now;
            _db.Trainnings.Add(model);
            await _db.SaveChangesAsync();
            return Result.Ok();
        }

        public async Task<Result> DeleteAsync(Trainning model)
        {
            Trainning trainningDb = await _db.Trainnings.Where(x => x.Id == model.Id && x.DisabledAt == null).FirstOrDefaultAsync();
            if (trainningDb == null)
            {
                Result.Fail("Erro");
            }
            trainningDb.DisabledAt = DateTime.Now;
            trainningDb.UpdatedAt = DateTime.Now;

            await _db.SaveChangesAsync();

            return Result.Ok();
        }

        public async Task<List<Trainning>> FindAllAsync()
        {
            List<Trainning> trainning = await _db.Trainnings.Where(x => x.DisabledAt == null).ToListAsync();
            return trainning;
        }

        public async Task<List<Trainning>> FindAllByIdPersonalAsync(string idPersonal)
        {
            List<Trainning> trainning = await _db.Trainnings.Where(x => x.DisabledAt == null && x.Personal.Id == idPersonal).ToListAsync();
            return trainning;
        }

        public async Task<Trainning> FindByIdAsync(int id)
        {
            Trainning trainning = await _db.Trainnings.Where(x => x.Id == id && x.DisabledAt == null)
                .Include(x => x.TrainningDays)
                .FirstOrDefaultAsync();
            return trainning;
        }

        public async Task<Trainning> FindByIdUserAsync(string userId)
        {
            Trainning trainning = await _db.Trainnings.Where(x => x.Users.Select(x => x.Id).Contains(userId)
                                                            && x.DisabledAt == null)
                                                .FirstOrDefaultAsync();
            return trainning;
        }

        public async Task<Result> UpdateAsync(Trainning model)
        {
            Trainning trainning = await _db.Trainnings.Where(x => x.Id == model.Id && x.DisabledAt == null).FirstOrDefaultAsync();
            trainning.UpdatedAt = DateTime.Now;
            trainning.FirstDay = model.FirstDay;
            trainning.LastDay = model.LastDay;
            trainning.Goal = model.Goal;
            trainning.Users = model.Users;
            trainning.TrainningDays = model.TrainningDays;

            _db.SaveChangesAsync();

            return Result.Ok();
        }
    }
}
