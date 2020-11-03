using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBMS.Data;
using GradeBookConsoleApp.Data;

namespace GradeBookConsoleApp.Data
{
    public class DmsSeeder
    {
        private readonly DMSContext ctx;

        public DmsSeeder(DMSContext ctx)
        {
            this.ctx = ctx;
        }


        public void Seed()
        {

            ctx.Database.EnsureCreated();

            if (!ctx.Company.Any())
            {
                var faculties = new List<Faculty>()
            {
                new Faculty
                {

               
                Name = "Incubator",
                OfficeAddress = " Office 1205 Room 12",
                RegisteredName = "Incubator",
                Website = "www.incubator.com",
                TraddingName = "Incu"
                }
            };

                var results1 = ctx.Faculty.Add(new Faculty
                {

                   
                    Name = "Incubator",
                    OfficeAddress = " Office 1205 Room 12",
                    RegisteredName = "Incubator",
                    Website = "www.incubator.com",
                    TraddingName = "Incu"
                });

                var address = new Address
                {
                    
                    Country = "South Africa",
                    Line1 = "43th Juta Str",
                    Line2 = "Braamfontain, Johannesburg",
                    PostalCode = 2000,
                    Province = "Gauteng",
                    Surburb = "Braamfontain"

                };
                var results = ctx.Address.Add(address);

                var Company = ctx.Company.Add(
                    new Company
                    {
                       
                        CompanyName ="Wits", 
                        Faculties = faculties, 
                        Address = address, 
                         

                    });

            }
            ctx.SaveChanges();
        }

    }
}
