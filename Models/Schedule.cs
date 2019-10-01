using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cb716316_christian_MIS4200.Models
{
    public class Schedule
    {
        [Key]
        public int scheduleID { get; set; }
        public ICollection<Classes> Classes { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}