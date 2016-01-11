namespace Seminar.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Seminar.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Seminar.Context context)
        {
            context.Cars.AddOrUpdate(
                c => c.Name,
                new Car{ Name = "Lada"},
                new Car{ Name = "Volkswagen"},
                new Car{ Name = "Mercedes"}
                );
            context.SaveChanges();
            context.Shops.AddOrUpdate(
                s => s.SName,
                new Shop { SName = "Pegasus" },
                new Shop { SName = "Express" }
                );
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
        }
    }
}
