namespace Code_First_Lab.Migrations.Places
{
    using Code_First_Lab.Models.Places;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Code_First_Lab.Models.Places.PlacesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\Places";
        }

        protected override void Seed(Code_First_Lab.Models.Places.PlacesContext context)
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

            context.Provinces.AddOrUpdate(
                p => p.provinceCode, DummyData.getProvinces().ToArray());
            context.SaveChanges();

            context.Cities.AddOrUpdate(
                c => c.cityID, DummyData.getCities().ToArray());
        }
    }
}
