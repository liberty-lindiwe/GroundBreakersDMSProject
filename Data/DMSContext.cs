using GradeBookConsoleApp.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.Data
{
    public class DMSContext : DbContext
    {
        public DMSContext(DbContextOptions<DMSContext> options ) :base (options)
        {

        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Incubator> Incubator { get; set; }
        public DbSet<Programme> Programme { get; set; }
        public DbSet<Beneficiary> Beneficiary { get; set; }
        public DbSet<StartUp> StartUp { get; set; }
        public DbSet<Representative> Representative { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Report> Report { get; set; }

        

    }
}
