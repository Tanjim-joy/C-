using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imran_1264705.Models
{
    public abstract class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string model, int make, int cc, string gearType, VehicleType type)
        {
            this.Model = model; this.Make = make; this.CC = cc; this.GearType = gearType; this.Type = type;
        }

        public string Model { get; set; }
        public int Make { get; set; }
        public int CC { get; set; }
        public string GearType { get; set; }
        public VehicleType Type { get; set; }
        protected int Wheels { get; set; }
        public override string ToString()
        {
            return $"ModeL: {this.Model}\nMake: {this.Make}\nCC: {CC}\nType: {this.Type}\n" +
                $"Gear Type: {GearType}";
        }

    }
}
