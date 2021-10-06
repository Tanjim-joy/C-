using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imran_1264705.Models
{
    public class Two_wheelers:Vehicle
    {
        public Two_wheelers() { this.Wheels = 2; }
        public Two_wheelers(string model, int make, int cc, string gearType, VehicleType type) : base(model, make, cc, gearType, type)
        {

            this.Wheels = 2;
        }
    }
}
