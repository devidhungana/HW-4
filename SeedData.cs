﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class SeedData
    {
        public static void initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
            serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                // look for any movies
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "GhostBusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "TV-MA"
                    },
                    new Movie
                    {
                        Title = "GhostBuster",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "TV-MA"
                    },
                    new Movie
                    {
                        Title = "Rio Barvo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "PG-13"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
