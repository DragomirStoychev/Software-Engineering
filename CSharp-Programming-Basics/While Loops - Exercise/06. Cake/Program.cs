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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double razmeri = a * b;

            string vzemane = "";
            double vzemaneP = 0;


            while (true)
            {
                vzemane = Console.ReadLine();
                if (vzemane == "STOP")
                {
                    Console.WriteLine("{0} pieces are left.", razmeri);
                    break;
                }
                vzemaneP = Convert.ToDouble(vzemane);
                razmeri -= vzemaneP;
                if (razmeri <= 0)
                {
                    Console.WriteLine("No more cake left! You need {0} pieces more.", Math.Abs(razmeri));
                    break;
                }
            }
        }
    }
}