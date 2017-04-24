using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Logo
{
    class SoftUni_Logo
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', 6 * N - 3) + '#' + new string('.', 6 * N - 3));
            for (int i = 0; i < 2 * N - 1; i++)
            {
                Console.WriteLine(new string('.', 6 * N - 6 - 3 * i) + new string('#', 6 * i + 7) + new string('.', 6 * N - 6 - 3 * i));
            }
            for (int j = 0; j <= N - 2; j++)
            {
                Console.WriteLine("|" + new string('.', 3 * j + 2) + new string('#', 12 * N - 6 * j - 11) + new string('.', 3 * j + 3));
                if (j == N - 2)
                {
                    for (int k = 0; k < N - 2; k++)
                    {
                        Console.WriteLine("|" + new string('.', 3 * j + 2) + new string('#', 12 * N - 6 * j - 11) + new string('.', 3 * j + 3));

                    }
                    Console.WriteLine("@" + new string('.', 3 * j + 2) + new string('#', 12 * N - 6 * j - 11) + new string('.', 3 * j + 3));
                }
            }
        }
    }
}