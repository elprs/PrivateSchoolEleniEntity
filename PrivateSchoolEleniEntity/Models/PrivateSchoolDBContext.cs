using System.Data.Entity;

namespace PrivateSchoolEleniEntity.Models
{
    public class PrivateSchoolDBContext : DbContext
    {
        public PrivateSchoolDBContext() : base("PrivateSchoolEleni")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}