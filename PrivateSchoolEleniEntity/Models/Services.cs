using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchoolEleniEntity.Models
{
    public class Services
    {
        public List<Student> Students { get; set; }
        public List<Trainer> Trainers { get; set; }
        public List<Assignment> Assignments { get; set; }
        public List<Course> Courses { get; set; }
    }
}