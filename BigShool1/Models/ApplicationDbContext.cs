using BigSchool1.Models;
using System;
using System.Data.Entity;


using System.Collections.Generic;

using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks; 

namespace BigShool1.Models
{
    internal class ApplicationDbContext : IdentityDbContext<ApplicationUser>

    {
        //public object Categories { get; internal set; }
        //public object Courses { get; internal set; }

        //internal void SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categorises { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}