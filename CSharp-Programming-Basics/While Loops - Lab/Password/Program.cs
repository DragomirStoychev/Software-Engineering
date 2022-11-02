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
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != password)
            {
                input = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {name}!");
        }
    }
}