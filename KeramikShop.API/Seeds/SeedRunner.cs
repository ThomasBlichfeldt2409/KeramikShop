using KeramikShop.API.Models;
using Microsoft.AspNetCore.Identity;

namespace KeramikShop.API.Seeds
{
    public static class SeedRunner
    {
        public static async Task SeedAsync(IServiceProvider services, IConfiguration config)
        {
            using var scope = services.CreateScope();

            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            await RoleSeeder.SeedRolesAsync(roleManager);
            await AdminSeeder.SeedAdminAsync(userManager, roleManager, config);
        }
    }
}
