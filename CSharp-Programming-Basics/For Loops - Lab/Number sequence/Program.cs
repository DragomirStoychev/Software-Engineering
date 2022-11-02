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
            int count = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number >= max)
                {
                    max = number;
                }
                if (number <= min)
                {
                    min = number;
                }
            }
            Console.WriteLine("Max number: {0}", max);
            Console.WriteLine("Min number: {0}", min);
        }
    }
}