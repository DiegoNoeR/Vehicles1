using Microsoft.EntityFrameworkCore;
using Vehicles.API.Data;
using Vehicles.API.Data.Entities;

namespace Vehicles.API.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DataContext>>()))
            {
                context.Database.EnsureCreated();
                if (!context.Procedures.Any())
                {
                    context.Procedures.AddRange(
                        new Procedure { Price = 10000, Description = "Alineación" },
                        new Procedure { Price = 10000, Description = "Lubricación de suspención delantera" },
                        new Procedure { Price = 10000, Description = "Lubricación de suspención trasera" },
                        new Procedure { Price = 10000, Description = "Frenos delanteros" }                        
                    );
                    context.SaveChanges();
                }

                if (!context.DocumentTypes.Any())
                {
                    context.DocumentTypes.AddRange(
                        new DocumentType { Description = "INE" },
                        new DocumentType { Description = "Pasaporte" },
                        new DocumentType { Description = "Cédula Profecional" },
                        new DocumentType { Description = "Cartilla Militar" },
                        new DocumentType { Description = "Licencia de conducir" }

                    );
                    context.SaveChanges();
                }

                if (!context.Brands.Any())
                {
                    context.Brands.AddRange(
                        new Brand { Description = "Toyota" },
                        new Brand { Description = "Ducati" },
                        new Brand { Description = "Mercedes Benz" },
                        new Brand { Description = "VW" },
                        new Brand { Description = "Ford" },
                        new Brand { Description = "Nisan" }


                    );
                    context.SaveChanges();
                }

                if (!context.VehicleTypes.Any())
                {
                    context.VehicleTypes.AddRange(
                        new VehicleType { Description = "Sedan" },
                        new VehicleType { Description = "SUV" },
                        new VehicleType { Description = "Hatchback" },
                        new VehicleType { Description = "Pic-up" }

                    );
                    context.SaveChanges();
                }

                
            }
        }
    }
}