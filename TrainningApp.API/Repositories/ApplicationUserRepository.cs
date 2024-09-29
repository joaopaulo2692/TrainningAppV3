using FluentResults;
using Microsoft.AspNetCore.Identity;
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
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, ApplicationDbContext db)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _db = db;
        }

        public async Task<Result> CreateAsync(ApplicationUser user)
        {
            var result = await _userManager.CreateAsync(user, user.PasswordHash);
            if(!result.Succeeded)
            {
                return Result.Fail("Erro");
            }
            ApplicationUser userDb = await _db.Users.Where(x => x.Id == user.Id).FirstOrDefaultAsync();
            userDb.EmailConfirmed = true;           
            await _db.SaveChangesAsync();

            return Result.Ok();
        }

        public async Task<ApplicationUser> GetById(string id)
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
