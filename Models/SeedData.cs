using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ComicCache.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComicCache.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ComicCacheContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<ComicCacheContext>>()))
            {
                //Look for any comics.
                if (context.Comic.Any())
                {
                    return; //DB has been seeded.
                }

                context.Comic.AddRange(
                    new Comic
                    {
                        Title = "Fantastic Four",
                        IssueNumber = 1,
                        YearReleased = 1996,
                        Publisher = "Marvel Comics",
                        BoxLocation = 4
                    },

                    new Comic
                    {
                        Title = "The Man of Steel",
                        IssueNumber = 1,
                        YearReleased = 1986,
                        Publisher = "DC Comics",
                        BoxLocation = 3
                    },

                    new Comic
                    {
                        Title = "Superman/Wonder Woman",
                        IssueNumber = 1,
                        YearReleased = 2013,
                        Publisher = "DC Comics",
                        BoxLocation = 2
                    },

                    new Comic
                    {
                        Title = "Ultimate Spider-Man",
                        IssueNumber = 1,
                        YearReleased = 2000,
                        Publisher = "Marvel Comics",
                        BoxLocation = 1
                    }                  
                  );
                  context.SaveChanges();
            }
        }
    }
}
