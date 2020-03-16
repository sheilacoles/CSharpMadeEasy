using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8_Employing_Partial_Classes
{
    public partial class Sailboat
    {
        private string make;
        private string model;

        public Sailboat( string make, string model)
        {
            this.make = make;
            this.model = model;
        }
    }
}
