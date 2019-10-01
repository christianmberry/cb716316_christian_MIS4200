using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cb716316_christian_MIS4200.Models
{
    public class Classes
    {
        [Key]
        public int classID { get; set; }
        public string className { get; set; }
        public string classRoom { get; set; }
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}