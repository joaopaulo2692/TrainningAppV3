using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainningApp.Core.Entities;
using TrainningApp.Core.RepositoriesInterface;

namespace TrainningApp.Infrastructure.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ApplicationUserRepository(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<ApplicationUser> GetUserById(string id)
        {
            ApplicationUser user = await _signInManager
                                .UserManager
                                .Users
                                .Where(x => x.DisabledAt == null &&
                                            x.Id == id)
                                .Include(x => x.Managements)
                                .FirstOrDefaultAsync();

            if (user is null)
                return null;

            if (user.Managements is not null)
                user.Managements = user.Managements.Where(x => x.DisabledAt == null).Distinct().ToList();

            return user;
        }
    }
}
