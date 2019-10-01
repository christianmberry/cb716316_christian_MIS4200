using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace cb716316_christian_MIS4200.Models
{
    public class Schedule
    {
        public int scheduleID { get; set; }
        public string semester { get; set; }

        public ICollection<ClassDetails> ClassDetails { get; set; }
        public int studentID { get; set; }
        public virtual Student Student{ get; set; }
    }
}