using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateSchoolEleniEntity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Course { get; set; }
        public decimal Fees { get; set; }


        [Display(Name = "Photo Link-Url")]
        [DataType(DataType.ImageUrl)]
        public string PhotoUrl { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        public string Telephone { get; set; }
    }
}