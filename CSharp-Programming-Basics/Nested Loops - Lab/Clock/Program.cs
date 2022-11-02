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
            int h;
            int m;

            for (int i = 0; i <= 23; i++)
            {
                for (int e = 0; e <= 59; e++)
                {
                    Console.WriteLine($"{i}:{e}");
                }
            }

        }
    }
}