using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_House
{
    class Dog_House
    {
        static void Main(string[] args)
        {
            double Lenght = double.Parse(Console.ReadLine());
            double Hight = double.Parse(Console.ReadLine());
            double FrontSide = Math.Pow(Lenght / 2, 2) - Math.Pow(Lenght / 5, 2) + ((Lenght / 2) * (Hight - Lenght / 2)) / 2;
            double BackSide = Math.Pow(Lenght / 2, 2) + ((Lenght / 2) * (Hight - Lenght / 2)) / 2; ;
            double SideWalls = 2 * (Lenght * Lenght / 2);
            double GreenArea = FrontSide + BackSide + SideWalls;
            double RedArea = 2 * (Lenght * Lenght / 2);
            double ExpenseGreen = GreenArea / 3;
            double ExpenseRed = RedArea / 5;
            Console.WriteLine($"{ExpenseGreen:f2}");
            Console.WriteLine($"{ExpenseRed:f2}");
        }
    }
}