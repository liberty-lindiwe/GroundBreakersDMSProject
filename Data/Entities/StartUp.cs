using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookConsoleApp.Data
{
    public class StartUp
    {
        public int StartUpID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public int AlternativeNumber { get; set; }
        public string officeAddress { get; set; }

        public ICollection<Beneficiary> Beneficiaries { get; set; }
        public DBMS.Data.Representative rep { get; set; }

    }
}
