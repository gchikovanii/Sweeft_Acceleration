using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightTask
{
    public class Country
    {
        public Name name { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
       
        public double[] latlng { get; set; }
        public double area { get; set; }
        public double population { get; set; }
    }
}
