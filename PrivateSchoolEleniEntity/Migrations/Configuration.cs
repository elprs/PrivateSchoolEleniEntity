namespace PrivateSchoolEleniEntity.Migrations
{
    using PrivateSchoolEleniEntity.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PrivateSchoolEleniEntity.Models.PrivateSchoolDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "PrivateSchoolEleniEntity.Models.PrivateSchoolDBContext";
        }

        protected override void Seed(PrivateSchoolEleniEntity.Models.PrivateSchoolDBContext context)
        {
            #region==========Students=============
            context.Students.AddOrUpdate(x => x.LastName,
                new Student() { FirstName = "Eleni", LastName = "Parisi", DateOfBirth = new DateTime(1979, 1, 14), Course = "C#", Fees = 2500 , PhotoUrl= "https://images.unsplash.com/photo-1548416891-ec94e947aafc?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=668&q=80", Email="eleni@gmail.com", Telephone="2223334444"},
                new Student() { FirstName = "Panagiota", LastName = "Vasileiou", DateOfBirth = new DateTime(1999, 12, 17), Course = "Java", Fees = 3500, PhotoUrl = "https://images.unsplash.com/photo-1574701147838-eb4e86cce813?ixlib=rb-1.2.1&auto=format&fit=crop&w=900&q=60", Email = "panagiota@gmail.com", Telephone = "2223334445" },
                new Student() { FirstName = "Stathis", LastName = "Psaltis", DateOfBirth = new DateTime(1986, 3, 19), Course = "Javascript", Fees = 1500, PhotoUrl = "https://images.unsplash.com/photo-1581620214443-366f2da81541?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjExMDk0fQ&auto=format&fit=crop&w=900&q=60", Email = "stathis@gmail.com", Telephone = "2223334446" },
                new Student() { FirstName = "Vaggelis", LastName = "Koronaios", DateOfBirth = new DateTime(1981, 3, 16), Course = "C#", Fees = 4500, PhotoUrl = "https://images.unsplash.com/flagged/photo-1567924160289-888a91f63fc0?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=900&q=60", Email = "vaggelis@gmail.com", Telephone = "222-333-4447" },
                new Student() { FirstName = "Antonis", LastName = "Sarris", DateOfBirth = new DateTime(2000, 6, 11), Course = "Java", Fees = 2500, PhotoUrl = "https://images.unsplash.com/photo-1568927198336-e9ae04365910?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=900&q=60", Email = "antonis@gmail.com", Telephone = "222 333 4448" }
                );
            #endregion

            #region==========Trainers=============
            context.Trainers.AddOrUpdate(x => x.LastName,
                new Trainer() { FirstName = "Eleni", LastName = "Parisi", Subject = Subject.Csharp },
                new Trainer() { FirstName = "Panos", LastName = "Vasileiou", Subject = Subject.Java },
                new Trainer() { FirstName = "Stathis", LastName = "Psaltis", Subject = Subject.HTML },
                new Trainer() { FirstName = "Vaggelis", LastName = "Koronaios", Subject = Subject.CSS },
                new Trainer() { FirstName = "Antonis", LastName = "Sarris",
                    Subject = Subject.JavaScript}
                );
            #endregion

            #region==========Courses=============
            context.Courses.AddOrUpdate(x => x.Title,
                new Course() { Title = "BC1", Assignment = "Project 1", StartDate = new DateTime(2020, 2, 2), EndDate = new DateTime(2020, 6, 6), Stream = "Java", Type = "FullTime" },
                new Course() { Title = "BC2", Assignment = "Project 2", StartDate = new DateTime(2020, 3, 3), EndDate = new DateTime(2020, 7, 6), Stream = "C#", Type = "PartTime" },
                new Course() { Title = "BC3", Assignment = "Project 3", StartDate = new DateTime(2020, 6, 27), EndDate = new DateTime(2020, 12, 6), Stream = "Java", Type = "FullTime" }
                );
            #endregion

            #region==========Assignments=============
            context.Assignments.AddOrUpdate(x => x.Title,
                new Assignment() { Title = "Project 1", SubDate = new DateTime(2020, 7, 6), Description = "Team", OralMark = 50, TotalMark = 99 },
                new Assignment() { Title = "Project 2", SubDate = new DateTime(2020, 8, 6), Description = "Individual", OralMark = 49, TotalMark = 92 },
                new Assignment() { Title = "Project 3", SubDate = new DateTime(2020, 9, 6), Description = "Individual", OralMark = 34, TotalMark = 90 },
                new Assignment() { Title = "Project 4", SubDate = new DateTime(2020, 10, 6), Description = "Team", OralMark = 45, TotalMark = 98 }
                );
            #endregion
        }
    }
}
