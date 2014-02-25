namespace AutoInsurance.Data.Migrations
{
    using AutoInsurance.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoInsurance.Data.Database>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AutoInsurance.Data.Database context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Car.AddOrUpdate(
                p => p.Id,
                new Car() {
                    Id = 1,
                    Manufacturer = "Ferrari",
                    Model = "F50",
                    PhotoUrl = "http://upload.wikimedia.org/wikipedia/commons/2/2c/SC06_1995_Ferrari_F50.jpg"
                },
                new Car() {
                    Id = 2,
                    Manufacturer = "Honda",
                    Model = "Civic",
                    PhotoUrl = "http://carplace.virgula.uol.com.br/wp-content/uploads/2013/01/Honda-Civic-Aero-Pack-1.jpg"
                },
                new Car() { 
                    Id = 3,
                    Manufacturer = "Volkswagen",
                    Model = "Fusca",
                    PhotoUrl = "http://listonas.com.br/wp-content/uploads/2013/04/fusca-listonas-2.jpg"                
                }
                );

  
            

        }
    }
}
