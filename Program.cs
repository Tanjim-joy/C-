using Imran_1264705.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imran_1264705
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car input");
            Car c = new Car();
            Console.Write("Model: ");
            c.Model = Console.ReadLine();
            Console.Write("Make: ");
            c.Make = int.Parse(Console.ReadLine());
            Console.Write("CC: ");
            c.CC = int.Parse(Console.ReadLine());
            Console.Write("Gear Type: ");
            c.GearType = Console.ReadLine();
            Console.Write("Type: [NormalCar,RacingCar, FamilyCar]");
            c.Type = (VehicleType)Enum.Parse(typeof(VehicleType), Console.ReadLine());

            Console.Write("Faeture: ");
            string input = Console.ReadLine();
            c.AddFeature(input.Split(','));
            Console.WriteLine("Car input");
            Console.WriteLine();
            Bike b = new Bike();
            Console.Write("Model: ");
            b.Model = Console.ReadLine();
            Console.Write("Make: ");
            b.Make = int.Parse(Console.ReadLine());
            Console.Write("CC: ");
            b.CC = int.Parse(Console.ReadLine());
            Console.Write("Gear Type: ");
            b.GearType = Console.ReadLine();
            Console.Write("Type: [NormalCar,RacingCar, FamilyCar]");
            b.Type = (VehicleType)Enum.Parse(typeof(VehicleType), Console.ReadLine());


            Console.Write("Faeture: ");
            string input1 = Console.ReadLine();
            b.AddFeature(input1.Split(','));
            Console.WriteLine();
            Console.WriteLine(c);
            Console.WriteLine();
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}

