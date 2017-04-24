using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Intervals
{
    class Game_Of_Intervals
    {
        static void Main(string[] args)
        {
            int Moves = int.Parse(Console.ReadLine());
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;
            double Point = 0;
            for (int i = 0; i < Moves; i++)
            {
                int Numbers = int.Parse(Console.ReadLine());
                if (Numbers >= 0 && Numbers <= 9)
                {
                    Point += 0.2 * Numbers;
                    count1++;
                }
                if (Numbers >= 10 && Numbers <= 19)
                {
                    Point += 0.3 * Numbers;
                    count2++;
                }
                if (Numbers >= 20 && Numbers <= 29)
                {
                    Point += 0.4 * Numbers;
                    count3++;
                }
                if (Numbers >= 30 && Numbers <= 39)
                {
                    Point += 50;
                    count4++;
                }
                if (Numbers >= 40 && Numbers <= 50)
                {
                    Point += 100;
                    count5++;
                }
                if (Numbers < 0 || Numbers > 50)
                {
                    Point = Point / 2;
                    count6++;
                }
            }
            Console.WriteLine($"{Point:f2}");
            Console.WriteLine($"From 0 to 9: {(double)count1 / Moves * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {((double)count2 / Moves) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {((double)count3 / Moves) * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {((double)count4 / Moves) * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {((double)count5 / Moves) * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {((double)count6 / Moves) * 100:f2}%");
        }
    }
}