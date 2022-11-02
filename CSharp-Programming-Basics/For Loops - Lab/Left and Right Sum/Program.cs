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
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumLeft += number;
            }
            for (int i = 0; i < n; i++)
            {
                int number2 = int.Parse(Console.ReadLine());
                sumRight += number2;
            }

            if (sumLeft == sumRight)
            {
                Console.WriteLine("Yes, sum = {0}",sumRight);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sumRight-sumLeft));
            }
        }
    }
}