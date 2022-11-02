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
            string tyrsenaKniga = Console.ReadLine();
            string kniga = "";
            int count = 0;

            while (tyrsenaKniga != kniga)
            {
                kniga = Console.ReadLine();
                count++;
                if (kniga == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine("You checked {0} books.", --count);
                    break;
                }
            }
            if (kniga != "No More Books")
            {
                Console.WriteLine("You checked {0} books and found it.", --count);
            }
        }
    }
}