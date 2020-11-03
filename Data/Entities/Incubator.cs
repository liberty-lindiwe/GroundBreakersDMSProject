using DBMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookConsoleApp.Data
{
    public class Incubator
    {
        public int IncubatorId { get; set; }
        public string Name { get; set; }
        public int RepresentativeId { get; set; }
        public int ProgrammeId { get; set; }

        public Representative Representative { get; set; }
        public ICollection<Programme> Programmes { get; set; }


    }
}
