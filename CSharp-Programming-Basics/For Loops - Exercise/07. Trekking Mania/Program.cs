using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            int people = 0;

            int musala = 0;
            int monblna = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;
            double totalPeople = 0;

            for (int i = 0; i < group; i++)
            {
                people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    musala += people;
                }
                else if (people <= 12)
                {
                    monblna += people;
                }
                else if (people <= 25)
                {
                    kilimandjaro += people;
                }
                else if (people <= 40)
                {
                    k2 += people;
                }
                else if (people >= 41)
                {
                    everest += people;
                }
            }
            totalPeople = musala + monblna + kilimandjaro + everest + k2;
            Console.WriteLine("{0:f2}%", musala / totalPeople * 100);
            Console.WriteLine("{0:f2}%", monblna / totalPeople * 100);
            Console.WriteLine("{0:f2}%", kilimandjaro / totalPeople * 100);
            Console.WriteLine("{0:f2}%", k2 / totalPeople * 100);
            Console.WriteLine("{0:f2}%", everest / totalPeople * 100);
        }
    }
}