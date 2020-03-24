namespace School.Database.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using School.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<School.Database.MyDatabase>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(School.Database.MyDatabase context)
        {
            Teacher t1 = new Teacher() { FirstName = "Giorgos", LastName = "Pasparakis", Email = "pasparakis@gmail.com", Telephone = "1234567890", Subjects = new List<Subject>() { }, PortofolioURLs = new List<string>() { }, Salary = 5000 } ;
            
            
           // context.Teachers.Add(t1);


        }
    }
}
