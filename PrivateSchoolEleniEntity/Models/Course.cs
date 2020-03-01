using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchoolEleniEntity.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Type { get; set; }
        public string Assignment { get; set; }
    }
}