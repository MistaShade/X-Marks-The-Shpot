using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, x, y;
            Console.Write("Enter the size of the X: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (y = 1; y <= num * 2 - 1; y++)
            {
                for (x = 1; x <= num * 2 - 1; x++)
                {
                    int dX = x > num ? x - num : num - x;
                    int dY = y > num ? y - num : num - y;

                    if (dX == dY)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }



    }
}
