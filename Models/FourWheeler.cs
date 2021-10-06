using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imran_1264705.Models
{
    public class FourWheeler : Vehicle
    {
        public FourWheeler() { this.Wheels = 4; }
        public FourWheeler(string model, int make, int cc, string gearType, VehicleType type) : base(model, make, cc, gearType, type)
        {

            this.Wheels = 4;
        }
    }
}
