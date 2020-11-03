using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.Data
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public int PostalCode { get; set; }
        public string Surburb { get; set; }
        public string  Province { get; set; }
        public string Country { get; set; }

    }
}
