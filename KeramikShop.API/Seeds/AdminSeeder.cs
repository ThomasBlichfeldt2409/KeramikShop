using KeramikShop.API.Models;
using Microsoft.AspNetCore.Identity;

namespace KeramikShop.API.Seeds
{
    public static class AdminSeeder
    {
        public static async Task SeedAdminAsync(
            UserManager<ApplicationUser> userManager, 
            RoleManager<IdentityRole> roleManager, 
            IConfiguration config)
        {
            string? email = config["AdminUser:Email"];
            string? password = config["AdminUser:Password"];

            var user = await userManager.FindByEmailAsync(email!);

            if (user != null)
            {
                return;
            }

            var admin = new ApplicationUser
            {
                UserName = email,
                Email = email,
                EmailConfirmed = true
            };

            var result = await userManager.CreateAsync(admin, password!);

            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(admin, Roles.Admin);
            }
        }
    }
}
