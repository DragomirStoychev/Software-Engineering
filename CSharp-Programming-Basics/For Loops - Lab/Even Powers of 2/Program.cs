using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = 2;


            for (int i = 0; i < n+1; i++)
            {
                number = Math.Pow(2, i);
                if (i % 2 == 0)
                {
                    Console.WriteLine(number);
                }                
            }
        }
    }
}