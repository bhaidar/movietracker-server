using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWatcher.Server.Models
{
    public class SeedUsers
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<MovieTrackerContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            context.Database.EnsureCreated();

            if (!context.Users.Any())
            {
                var user = new ApplicationUser()
                {
                    Email = "bhaidar@gmail.com",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "bhaidar"
                };

                userManager.CreateAsync(user, "MySp$cialPassw0rd");
            }
        }
    }
}
