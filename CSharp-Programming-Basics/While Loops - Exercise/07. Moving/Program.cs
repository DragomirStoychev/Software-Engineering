using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int freeSpace = a * b * c;

            string input = "";
            int box = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input == "Done")
                {

                    Console.WriteLine("{0} Cubic meters left.", Math.Abs(freeSpace));
                    break;
                }
                box = Convert.ToInt32(input);
                freeSpace -= box;
                if (freeSpace <= 0)
                {

                    Console.WriteLine("No more free space! You need {0} Cubic meters more.", Math.Abs(freeSpace));
                    break;
                }
            }
        }
    }
}