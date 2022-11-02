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
            double max = double.MinValue;

            while (input != "Stop")
            {
                double number = Convert.ToDouble(input);
                if (number > max)
                {
                    max = number;
                }
                input = Console.ReadLine();
            }
            if (input == "Stop")
            {
                Console.WriteLine(max);
            }
        }
    }
}