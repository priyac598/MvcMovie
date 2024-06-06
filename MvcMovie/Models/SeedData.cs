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
                        Title = "Mr Bean",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Comedy",
                        Price = 7.99M,
                        Rating = "4.0"
                    },
                    new Movie
                    {
                        Title = "Beautiful flowers ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Korean Drama",
                        Price = 8.99M,
                        Rating = "3.2"
                    },
                    new Movie
                    {
                        Title = "Ghost",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Thriller",
                        Price = 9.99M,
                        Rating = "4.5"
                    },
                    new Movie
                    {
                        Title = "RRR",
                        ReleaseDate = DateTime.Parse("2022-4-15"),
                        Genre = "Action",
                        Price = 3.99M,
                        Rating = "4.4"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}