using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace SportsStore.Models
{
    public class SeedData
    {
        public void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "boat",
                        Category = "Water",
                        Price = 100
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "jacket",
                        Category = "Water",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Ball",
                        Description = "ball",
                        Category = "Football",
                        Price = 3
                    },
                    new Product
                    {
                        Name = "Goalpost",
                        Description = "post",
                        Category = "Football",
                        Price = 1000
                    });

                context.SaveChanges();
            }
        }
    }
}
