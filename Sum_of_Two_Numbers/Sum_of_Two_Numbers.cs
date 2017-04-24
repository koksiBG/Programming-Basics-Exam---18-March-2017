using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Two_Numbers
{
    class Sum_of_Two_Numbers
    {
        static void Main(string[] args)
        {
            int Begin = int.Parse(Console.ReadLine());
            int End = int.Parse(Console.ReadLine());
            int MagicalNumber = int.Parse(Console.ReadLine());
            int count = 0;
            int count1 = 0;
            for (int i = Begin; i <= End; i++)
            {
                for (int j = Begin; j <= End; j++)
                {
                    if (i + j <= MagicalNumber)
                    {
                        count++;
                        if (count > 0 && (i + j == MagicalNumber))
                        {
                            Console.WriteLine($"Combination N:{count} ({i} + {j} = {MagicalNumber})");
                            return;
                        }
                    }
                    if (i + j != MagicalNumber) count1++; 
                }
            }
            if (count1 > 0) Console.WriteLine($"{count1} combinations - neither equals {MagicalNumber}");
        }
    }
}