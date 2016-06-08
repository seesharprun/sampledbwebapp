using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDBWebApp.Models
{
    public class SchoolContext : DbContext
    {
        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(new SchoolContextInitializer());
        }
        
        public SchoolContext() :
            base ("DatabaseConnection")
        { }

        public DbSet<Student> Students { get; set; }
    }
}
