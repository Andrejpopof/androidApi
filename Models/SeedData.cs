using apiMSAP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiMSAP.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new apiMSAPContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<apiMSAPContext>>()))
            {
                // Look for any movies.
                if (context.Post.Any())
                {
                    return;   // DB has been seeded
                }

                context.Post.AddRange(
                    new Post
                    {
                        Naslov = "Air Jordan 4",
                        Cena = "200 EURO"
                    },
                     new Post
                     {
                         Naslov = "Air Max 720 OBJ",
                         Cena = "230 EURO"
                     },
                      new Post
                      {
                          Naslov = "Nike React",
                          Cena = "180 EURO"
                      },
                       new Post
                       {
                           Naslov = "Yeezy 500",
                           Cena = "400 EURO"
                       },
                        new Post
                        {
                            Naslov = "Yeezy 700",
                            Cena = "450 EURO"
                        },
                         new Post
                         {
                             Naslov = "Nike React",
                             Cena = "230 EURO"
                         }


                );
                context.SaveChanges();
            }
        }
    }
}
