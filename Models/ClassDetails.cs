using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cb716316_christian_MIS4200.Models
{
    public class ClassDetails
    {
        [Key]
        public int classID { get; set; }
        [Display(Name = "Class Name")]
        [Required(ErrorMessage = "Class must have a name.")]
        [StringLength(20)]
        public string className { get; set; }
        [Display(Name = "Class Room")]
        [Required(ErrorMessage = "Class must have a room.")]
        [StringLength(20)]
        public string classRoom { get; set; }
        [Display(Name = "Professor's Last Name")]
        [Required(ErrorMessage = "Class must have professor.")]
        [StringLength(20)]
        public string profLastName { get; set; }

        public int scheduleID { get; set; }
        [Display(Name = "Schedule")]
        public virtual Schedule Schedule { get; set; }

        public int studentID { get; set; }
        [Display(Name = "Student")]
        public virtual Student Student { get; set; }
    }
}