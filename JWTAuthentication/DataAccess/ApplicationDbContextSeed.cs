using JWTAuthentication.Constants;
using JWTAuthentication.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthentication.Contexts
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedEssentialsAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.Administrator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Moderator.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));

            //Seed Default User
            var defaultUser = new ApplicationUser { UserName = Authorization.DEFAULT_USERNAME, Email = Authorization.DEFAULT_EMAIL, EmailConfirmed = true, PhoneNumberConfirmed = true };

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                await userManager.CreateAsync(defaultUser, Authorization.DEFAULT_PASSWORD);
                await userManager.AddToRoleAsync(defaultUser, Roles.Administrator.ToString());
            }
        }
    }
}
