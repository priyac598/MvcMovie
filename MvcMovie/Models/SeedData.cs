using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Playful Kiss",
                        ReleaseDate = DateTime.Parse("1989-5-17"),
                        Genre = "Romantic",
                        Price = 7.99M,
                        Rating = "4.0"
                    },
                    new Movie
                    {
                        Title = "My Man is Cupid ",
                        ReleaseDate = DateTime.Parse("2020-1-15"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "5.0"
                    },
                    new Movie
                    {
                        Title = "Murari",
                        ReleaseDate = DateTime.Parse("1995-2-23"),
                        Genre = "Action",
                        Price = 9.99M,
                        Rating = "4.2"
                    },
                    new Movie
                    {
                        Title = "KGF",
                        ReleaseDate = DateTime.Parse("2023-4-15"),
                        Genre = "Action",
                        Price = 3.99M,
                        Rating = "4.5"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}