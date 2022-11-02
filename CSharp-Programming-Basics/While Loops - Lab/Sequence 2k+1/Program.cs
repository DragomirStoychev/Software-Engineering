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
            int k = 1;
            int result = n;

            while (n >= result)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
                result = k;
            }
        }
    }
}