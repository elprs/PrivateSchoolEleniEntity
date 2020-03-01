using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateSchoolEleniEntity.Models
{
    public class Trainer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject Subject { get; set; }
        
    }
}