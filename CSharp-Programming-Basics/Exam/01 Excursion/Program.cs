using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double numberOfNights = double.Parse(Console.ReadLine());
            double transport = double.Parse(Console.ReadLine());
            double tickets = double.Parse(Console.ReadLine());

            double noshtuvki = numberOfNights * 20;
            double kartiTransport = transport * 1.60;
            double biletiMuzei = tickets * 6.00;

            double obshtaSumaZaChovek = noshtuvki + kartiTransport + biletiMuzei;
            double Sum = obshtaSumaZaChovek * numberOfPeople;

            double result1 = Sum * 0.25;
            double result = result1 + Sum;
            Console.WriteLine($"{result:f2}");

        }
    }
}