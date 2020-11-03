using DBMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookConsoleApp.Data
{
    public class Beneficiary
    {
        public int BeneficiaryID { get; set; }
        public string FirstName  { get; set; }
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
        public int Said { get; set; }
        public string passport { get; set; }
        public string imigration { get; set; }
        public string CountryOfBirth { get; set; }
        public string HomeLanguage { get; set; }
        public string Gender { get; set; }
        public string Race { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public int AlternativeNumber { get; set; }
     
        public bool LiveinTownShip { get; set; }
        public string highestQaulification { get; set; }
        public string  highestEducation { get; set; }
        public string Tertiary { get; set; }
        public string Position { get; set; }
        public string TotalWorkExperiance { get; set; }

        public Address Address { get; set; }


    }
}
