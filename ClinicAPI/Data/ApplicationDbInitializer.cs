using ClinicAPI.Models;
using Microsoft.AspNetCore.Identity;

namespace ClinicAPI.Data
{
    public class ApplicationDbInitializer
    {
        public static async Task SeedRolesAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }
            if (!await roleManager.RoleExistsAsync("Pharmacist"))
            {
                await roleManager.CreateAsync(new IdentityRole("Pharmacist"));
            }
            if (!await roleManager.RoleExistsAsync("Doctor"))
            {
                await roleManager.CreateAsync(new IdentityRole("Doctor"));
            }
            if (!await roleManager.RoleExistsAsync("Analyzer"))
            {
                await roleManager.CreateAsync(new IdentityRole("Analyzer"));
            }

            if (!await roleManager.RoleExistsAsync("User"))
            {
                await roleManager.CreateAsync(new IdentityRole("User"));
            }
        }
    }
}
