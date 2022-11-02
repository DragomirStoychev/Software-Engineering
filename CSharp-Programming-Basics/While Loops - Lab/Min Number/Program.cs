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
            string input = Console.ReadLine();
            double min = double.MaxValue;

            while (input != "Stop")
            {
                double number = Convert.ToDouble(input);
                if (number < min)
                {
                    min = number;
                }
                input = Console.ReadLine();
            }
            if (input == "Stop")
            {
                Console.WriteLine(min);
            }
        }
    }
}