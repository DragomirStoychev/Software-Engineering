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
            double nezadovolitelniOcenki = int.Parse(Console.ReadLine());
            string zadacha = "";
            double ocenka = 0;
            double obshtaOcenka = 0;
            double broiZadachiPod4 = 0;
            double broiZadachi = 0;

            while (zadacha != "Enough")
            {
                string poslednaZadacha = zadacha;
                zadacha = Console.ReadLine();
                if (zadacha == "Enough")
                {
                    Console.WriteLine("Average score: {0:f2}", obshtaOcenka / broiZadachi);
                    Console.WriteLine("Number of problems: {0}", broiZadachi);
                    Console.WriteLine("Last problem: {0}", poslednaZadacha);
                    break;
                }
                ocenka = double.Parse(Console.ReadLine());
                obshtaOcenka += ocenka;
                broiZadachi++;
                if (ocenka <= 4)
                {
                    broiZadachiPod4++;
                }
                if (broiZadachiPod4 >= nezadovolitelniOcenki)
                {
                    Console.WriteLine("You need a break, {0} poor grades.", broiZadachiPod4);
                    break;
                }
            }
        }
    }
}