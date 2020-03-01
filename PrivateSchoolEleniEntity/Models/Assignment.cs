using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateSchoolEleniEntity.Models
{
    public class Assignment
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z' ''#''-'0-9\s]{1,40}$")]
        [Required(ErrorMessage = "The title is required")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [RegularExpression(@"^[a-zA-Z' ''#''-'\s]{1,40}$")]
        [Required(ErrorMessage = "The title is required")]
        [Display(Name = "Cooperation description")]
        public string Description { get; set; }
        //Must Fix the date validation ------------------------
        [Range(typeof(DateTime), "1/2/2020", "3/12/2020",
       ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Display(Name = "Submission Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime SubDate { get; set; }

        [RegularExpression(@"^[0-9]{1,10}$")]
        [Range(1, 50,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Oral Mark")]
        public double OralMark { get; set; }
        [RegularExpression(@"^[0-9]{1,10}$")]
        [Range(1, 100,
        ErrorMessage = "Value for {0} must be between {1} and {2}.")]
        [Display(Name = "Total Mark")]
        public double TotalMark { get; set; }
        
    }
}