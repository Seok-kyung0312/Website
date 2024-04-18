using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using INFORMATIONS.Data;
using System;
using System.Linq;
using INFORMATIONS.Models;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<ApplicationDbContext>>()))
        {
            // Look for any movies.
            if (context.Profile.Any())
            {
                return;   // DB has been seeded
            }
            context.Profile.AddRange(
                new Profile
                {
                    Name = "Lee ' Faker' SangHyeok",
                    Birthday = DateTime.Parse("1996-05-07"),
                    Country = "South Korea",
                    Team = "T1",
                    Role = "Mid laner",
                    Soloqueue = "Hide on bush",
                    Year = 10,
                    Img = "https://img.redbull.com/images/c_crop,w_3195,h_2130,x_5,y_0,f_auto,q_auto/c_scale,w_1500/redbullcom/2020/12/16/c61kpj1fxidgnwiqgz2h/faker-t1-main"
                },
                new Profile
                {
                    Name = "Lee ' Faker' SangHyeok",
                    Birthday = DateTime.Parse("1996-05-07"),
                    Country = "South Korea",
                    Team = "T1",
                    Role = "Mid laner",
                    Soloqueue = "Hide on bush",
                    Year = 10,
                    Img = "https://img.redbull.com/images/c_crop,w_3195,h_2130,x_5,y_0,f_auto,q_auto/c_scale,w_1500/redbullcom/2020/12/16/c61kpj1fxidgnwiqgz2h/faker-t1-main"

                }

            );
            context.SaveChanges();
        }
    }
}