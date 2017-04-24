using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_hours
{
    class Work_hours
    {
        static void Main(string[] args)
        {
            int Hours = int.Parse(Console.ReadLine());
            int Workers = int.Parse(Console.ReadLine());
            int WorkingDays = int.Parse(Console.ReadLine());
            int WorkingManHours = Workers * WorkingDays * 8;
            if (WorkingManHours >= Hours) Console.WriteLine($"{WorkingManHours - Hours} hours left");
            else
            {
                int overtime = Hours - WorkingManHours;
                int Penalties = overtime * WorkingDays;
                Console.WriteLine($"{overtime} overtime");
                Console.WriteLine($"Penalties: {Penalties}");
            }
        }
    }
}