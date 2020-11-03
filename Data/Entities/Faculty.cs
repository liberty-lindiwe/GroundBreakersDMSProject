using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookConsoleApp.Data
{
    public class Faculty
    {
        public int ID { get; set; }
        public string  Name { get; set; }
        public string TraddingName { get; set; }
        public string RegisteredName { get; set; }
        public string OfficeAddress { get; set; }
        public string Website { get; set; }

       

        public ICollection<Incubator> Incubators { get; set; }

    }
}
