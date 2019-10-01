using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cb716316_christian_MIS4200.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace cb716316_christian_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public  MIS4200Context() : base ("name=DefaultConnection")
        {

        }
        public  DbSet<Student> Students { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ClassDetails> ClassDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

    }
}