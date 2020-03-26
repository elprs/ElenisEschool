namespace School.Database.Migrations
{
    using System;
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
            Student s1 = new Student() { FirstName = "Eleni", LastName = "Parisi", Email = "parisi@gmail.com", Telephone = "6971234567" };
            Student s2 = new Student() { FirstName = "Stathis", LastName = "Kanellis", Email = "kanellis@gmail.com", Telephone = "6971234568" };
            Student s3 = new Student() { FirstName = "Giorgos", LastName = "Poulakos", Email = "poulakos@gmail.com", Telephone = "6971234569" };
            Student s4 = new Student() { FirstName = "Vaggelis", LastName = "Koutsogiorgos", Email = "koutsogiorgos@gmail.com", Telephone = "6971234510" };


            //context.Students.Add(s1);
            //context.Students.Add(s2);
            //context.Students.Add(s3);
            //context.Students.Add(s4);

            Discount d1 = new Discount() { Title = "Early bird", Percentage = 0.30 };
            Discount d2 = new Discount() { Title = "Social criteria", Percentage = 0.50 };
            Discount d3 = new Discount() { Title = "Recommended friend", Percentage = 0.10 };
            Discount d4 =  new Discount() { Title = "Black Friday", Percentage = 0.40 };

            //context.Discounts.Add(d1);
            //context.Discounts.Add(d2);
            //context.Discounts.Add(d3);
            //context.Discounts.Add(d4);


           // FIX IT

            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
            //#####################
            //#####################Unable to determine the principal end of the 'School.Database.Payment_Discount' relationship. Multiple added entities may
           // have the same primary key

            //!!!!!!!!!!!!the total amount needs to be calculated"!!!!!!!!!!
            Payment p1 = new Payment() { TotalAmount = 1000, DueDate = new DateTime(2020, 10, 12), IsCompleted = false };
            Payment p2 = new Payment() { TotalAmount = 2000, DueDate = new DateTime(2020, 09, 12), IsCompleted = false };
            Payment p3 = new Payment() { TotalAmount = 3000, DueDate = new DateTime(2020, 08, 12), IsCompleted = false };
            Payment p4 = new Payment() { TotalAmount = 2500, DueDate = new DateTime(2020, 07, 12), IsCompleted = false };

            //context.Payments.Add(p1);
            //context.Payments.Add(p2);
            //context.Payments.Add(p3);
            //context.Payments.Add(p4);

            // Subject s1 = new Subject() { Title = "HTML", Assignment = new Assignment}




            Teacher t1 = new Teacher() { FirstName = "Giorgos", LastName = "Pasparakis", Email = "pasparakis@gmail.com", Telephone = "1234567890", Subjects = new List<Subject>() { }, PortofolioURLs = new List<string>() { }, Salary = 5000 } ;
            
            
           // context.Teachers.Add(t1);


        }
    }
}
