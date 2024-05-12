using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}
