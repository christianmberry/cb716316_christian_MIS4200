using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace cb716316_christian_MIS4200.Models
{
    public class Schedule
    {
        public int scheduleID { get; set; }
        [Display(Name = "Semester (Fall, Spring, Summer)")]
        [Required(ErrorMessage = "Student must be enrolled in a semester.")]
        [StringLength(20)]
        public string semester { get; set; }
        public ICollection<ClassDetails> ClassDetails { get; set; }
        public int studentID { get; set; }
        public virtual Student Student{ get; set; }
    }
}