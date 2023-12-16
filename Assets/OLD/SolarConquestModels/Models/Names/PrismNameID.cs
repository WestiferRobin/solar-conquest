using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarConquest
{
    public class PrismNameID
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public PrismNameID(string firstName, string lastName) { 
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
