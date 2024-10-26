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
    public class ExerciseRepository : IExerciseRepository
    {
        private readonly ApplicationDbContext _db;

        public ExerciseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Result> CreateAsync(Exercise exercise)
        {
            exercise.UpdatedAt = DateTime.Now;
            exercise.CreatedAt  = DateTime.Now;

            _db.Exercises.Add(exercise);
            await _db.SaveChangesAsync();

            return Result.Ok();
        }

        public async Task<Result> DeleteAsync(Exercise exercise)
        {
            Exercise dbExercise = await _db.Exercises.Where(x => x.Equals(exercise)).FirstOrDefaultAsync();

            dbExercise.UpdatedAt = DateTime.Now;
            dbExercise.DisabledAt = DateTime.Now;

            _db.SaveChangesAsync();

            return Result.Ok();
        }

        public async Task<List<Exercise>> FindAllAsync()
        {
            List<Exercise> exercises = await _db.Exercises.Where(x => x.DisabledAt == null).ToListAsync();

            return exercises;
        }

        public async Task<Exercise> FindByIdAsync(int id)
        {
            Exercise dbExercise = await _db.Exercises.Where(x => x.Equals(id) && x.DisabledAt == null)
                .Include(x => x.Muscles)
                .FirstOrDefaultAsync();

            return dbExercise;

        }

        public async Task<Result> UpdateAsync(Exercise exercise)
        {
            Exercise dbExercise = await _db.Exercises.Where(x => x.Equals(exercise)).FirstOrDefaultAsync();
            dbExercise.UpdatedAt = DateTime.Now;
            dbExercise.Muscles = exercise.Muscles;
            dbExercise.TrainningExercises = exercise.TrainningExercises;
            dbExercise.Name = exercise.Name;

            await _db.SaveChangesAsync();

            return Result.Ok();

        }
    }
}
