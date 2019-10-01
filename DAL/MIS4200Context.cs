using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cb716316_christian_MIS4200.Models;
using System.Data.Entity;

namespace cb716316_christian_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public  MIS4200Context() : base ("name=DefaultConnection")
        {

        }
        public  DbSet<Student> Student { get; set; }
        public DbSet<Classes> Classes { get; set; }

        public System.Data.Entity.DbSet<cb716316_christian_MIS4200.Models.Professor> Professors { get; set; }

        public System.Data.Entity.DbSet<cb716316_christian_MIS4200.Models.Schedule> Schedules { get; set; }
    }
}