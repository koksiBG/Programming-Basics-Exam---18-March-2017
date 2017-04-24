using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_To_Go
{
    class Car_To_Go
    {
        static void Main(string[] args)
        {
            double Budget = double.Parse(Console.ReadLine());
            string Season = Console.ReadLine();
            string Class = "";
            string Car = "";
            double Rent = 0;
            if (Budget <= 100)
            {
                Class = "Economy class";
                if (Season == "Summer")
                {
                    Car = "Cabrio";
                    Rent = 0.35 * Budget;
                }
                if (Season == "Winter")
                {
                    Car = "Jeep";
                    Rent = 0.65 * Budget;
                }
            }
            if (Budget >= 100 && Budget <= 500)
            {
                Class = "Compact class";
                if (Season == "Summer")
                {
                    Car = "Cabrio";
                    Rent = 0.45 * Budget;
                }
                if (Season == "Winter")
                {
                    Car = "Jeep";
                    Rent = 0.80 * Budget;
                }
            }
            if (Budget > 500)
            {
                Class = "Luxury class";
                Car = "Jeep";
                Rent = 0.90 * Budget;
            }
            Console.WriteLine($"{Class}");
            Console.WriteLine($"{Car} - {Rent:f2}"); 
        }
    }
}