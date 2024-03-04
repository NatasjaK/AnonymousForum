using AnonymousForum.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace AnonymousForum.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ForumContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ForumContext>>()))
            {
                // Look for any topics.
                if (context.Topics.Any())
                {
                    return;   // DB has been seeded
                }

                context.Topics.AddRange(
                    new Topic { Title = "Artificial Intelligence" },
                    new Topic { Title = "Space Exploration" },
                    new Topic { Title = "Social Media" }
                );

                context.SaveChanges();
            }
        }
    }
}
