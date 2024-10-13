using FluentResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.DTO.TrainningExercise;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;
using TrainningApp.Infrastructure.Data;

namespace TrainningApp.Infrastructure.Repositories
{
    public class TrainningExerciseRepository : ITrainningExerciseRepository
    {
        private readonly ApplicationDbContext _db;

        public TrainningExerciseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Result> CreateAsync(TrainningExercise trainningExercise)
        {
            trainningExercise.UpdatedAt = DateTime.Now;
            trainningExercise.CreatedAt = DateTime.Now;

            _db.TrainningExercises.Add(trainningExercise);

            await _db.SaveChangesAsync();

            return Result.Ok().WithSuccess(trainningExercise.Id.ToString());
        }

        public async Task<Result> DeleteAsync(TrainningExercise trainningExercise)
        {
            TrainningExercise dbTrainningExercise = await _db.TrainningExercises.Where(x => x.Id == trainningExercise.Id).FirstOrDefaultAsync();
            dbTrainningExercise.UpdatedAt = DateTime.Now;
            dbTrainningExercise.DisabledAt = DateTime.Now;

            await _db.SaveChangesAsync();

            return Result.Ok();
        }

        public async Task<TrainningExercise> FindByIdAsync(int trainningExerciseId)
        {
            TrainningExercise dbTrainningExercise = await _db.TrainningExercises.Where(x => x.Id == trainningExerciseId).FirstOrDefaultAsync();

            return dbTrainningExercise;
        }

        public async Task<List<TrainningExercise>> FindByIdsAsync(List<int> trainningExerciseIds)
        {
            List<TrainningExercise> trainningExercises = new List<TrainningExercise>();
            List<TrainningExercise> dbTrainningExercises = await _db.TrainningExercises.Where(x => x.Equals(trainningExerciseIds)).ToListAsync();

            return dbTrainningExercises;
        }

        public async Task<Result> UpdateAsync(TrainningExercise trainningExercise)
        {
            TrainningExercise dbTrainningExercise = await _db.TrainningExercises.Where(x => x.Id == trainningExercise.Id).FirstOrDefaultAsync();
            dbTrainningExercise.UpdatedAt = DateTime.Now;
            dbTrainningExercise.Reps = trainningExercise.Reps;
            dbTrainningExercise.Set = trainningExercise.Set;
            dbTrainningExercise.Ordenation = trainningExercise.Ordenation;
            dbTrainningExercise.Info = trainningExercise.Info;
            dbTrainningExercise.Exercise = trainningExercise.Exercise;
            dbTrainningExercise.TrainningDay = trainningExercise.TrainningDay;

            await _db.SaveChangesAsync();

            return Result.Ok();
        }
    }
}
