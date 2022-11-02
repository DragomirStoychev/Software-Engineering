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
            double totalTickets = 0;
            string input = "";
            double Tickets = 0;
            double student = 0;
            double standard = 0;
            double kids = 0;
            string seat = "";
            double takenTickets = 0;
            double takenTickets2 = 0;

            while (true)
            {

                if (seat == "Finish")
                {
                    Console.WriteLine($"Total tickets: {takenTickets2}");
                    Console.WriteLine($"{((student / takenTickets2) * 100):f2}% student tickets.");
                    Console.WriteLine($"{((standard / takenTickets2) * 100):f2}% standard tickets.");
                    Console.WriteLine($"{((kids / takenTickets2) * 100):f2}% kids tickets.");
                    break;
                }
                input = Console.ReadLine();
                Tickets = double.Parse(Console.ReadLine());

                while (true)
                {
                    seat = Console.ReadLine();
                    if (seat == "End" || seat == "Finish")
                    {
                        Console.WriteLine($"{input} - {((takenTickets / Tickets) * 100):f2}% full.");
                        takenTickets = 0;
                        break;
                    }
                    else if (seat == "standard")
                    {
                        standard++;
                        takenTickets++;
                        takenTickets2++;
                    }
                    else if (seat == "student")
                    {
                        student++;
                        takenTickets++;
                        takenTickets2++;
                    }
                    else if (seat == "kid")
                    {
                        kids++;
                        takenTickets++;
                        takenTickets2++;
                    }
                }
            }
        }
    }
}