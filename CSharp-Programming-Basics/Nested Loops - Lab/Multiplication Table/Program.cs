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
            for (int i = 1; i <= 10; i++)
            {
                for (int e = 1; e <= 10; e++)
                {
                    int x = i * e;
                    Console.WriteLine($"{i} * {e} = {x}");
                }

            }

        }
    }
}