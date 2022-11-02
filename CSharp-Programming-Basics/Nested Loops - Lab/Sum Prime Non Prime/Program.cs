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
            string input = "";
            int prime = 0;
            int nonPrime = 0;
            

            while (input != "stop")
            {
                input = Console.ReadLine();
                bool isNumberPrime = true;
                if (input == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {prime}");
                    Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
                    return;
                }
                int number = Convert.ToInt32(input);
                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isNumberPrime = false;
                        break;
                    }
                }
                if (isNumberPrime)
                {
                    prime += number;
                }
                else
                {
                    nonPrime += number;
                }
            }
        }
    }
}