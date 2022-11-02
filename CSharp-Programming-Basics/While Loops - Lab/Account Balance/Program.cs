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
            double sum = 0;
            double deposit = 0;

            while (input != "NoMoreMoney")
            {
                deposit = Convert.ToDouble(input);

                if (deposit < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine("Total: {0:f2}", sum);
                    break;
                }
                else
                {
                    Console.WriteLine("Increase: {0:f2}", deposit);
                    sum += deposit;
                    input = Console.ReadLine();
                }
            }
            if (input == "NoMoreMoney")
            {
                Console.WriteLine("Total: {0:f2}", sum);
            }
        }
    }
}