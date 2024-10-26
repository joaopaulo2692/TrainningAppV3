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
    public class MuscleRepository : IMuscleRepository
    {
        private readonly ApplicationDbContext _db;

        public MuscleRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Muscle> FindByNameAsync(string name)
        {
            Muscle muscle = await _db.Muscles.Where(x => x.Name == name).FirstOrDefaultAsync();
            return muscle;
        }
    }
}
