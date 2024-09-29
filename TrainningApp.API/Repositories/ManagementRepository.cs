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
    public class ManagementRepository : IManagementRepository
    {
        private readonly ApplicationDbContext _db;

        public ManagementRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Management> FindByUserId(string userId)
        {
            Management management = await _db.Managements.Where(x => x.Users.Select(x => x.Id).Contains(userId)).FirstOrDefaultAsync();

            return management;
        }
    }
}
