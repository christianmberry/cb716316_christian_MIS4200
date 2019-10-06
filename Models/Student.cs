using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cb716316_christian_MIS4200.Models
{
    public class Student
    {
        public int studentID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Student must have a first name.")]
        [StringLength(20)]
        public string firstName { get; set; }
        [Display (Name ="Last Name")]
        [Required(ErrorMessage = "Student must have a last name.")]
        [StringLength(20)]
        public string lastName { get; set; }
        [Display(Name = "Main Email Address")]
        [Required(ErrorMessage = "Student must have an email.")]
        [StringLength(100)]
        public string email { get; set; }
        [Display(Name = "Year Enrolled in School (FR, SO, JR, SR or 1, 2, 3, 4)")]
        [Required(ErrorMessage = "Student must have a grade level.")]
        [StringLength(15)]
        public string year { get; set; }
        
        public ICollection<Schedule> Schedules { get; set; }
    }
}