using DBMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookConsoleApp.Data
{
    public class Programme
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public int Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ProgrammeFunder { get; set; }
        public int NumberOfProgrammApplicants { get; set; }
        public string Purpose { get; set; }
        public bool Active { get; set; }
        public string  PartnerShipAgreeing { get; set; }


        public ICollection<StartUp> StartUps { get; set; }

        public ICollection<Beneficiary> Beneficiaries { get; set; }

        public ICollection<Report>  Reports { get; set; }




    }
}
