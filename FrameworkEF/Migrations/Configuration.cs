namespace FrameworkEF.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FrameworkEF.SchoolContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = true;
            //AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(FrameworkEF.SchoolContext context)
        {

            IList<Country> countries = new List<Country>();

            countries.Add(new Country() { CountryName = "India"});
            countries.Add(new Country() { CountryName = "Sri Lanka" });
            countries.Add(new Country() { CountryName = "USA" });


            context.Countries.AddRange(countries);

            base.Seed(context);

            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
