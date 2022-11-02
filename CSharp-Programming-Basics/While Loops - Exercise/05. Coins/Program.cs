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
            double resto = double.Parse(Console.ReadLine());
            double restoST = resto * 100;

            double restoMONETI = 0;


            while (restoST > 0)
            {
                if (restoST > 200)
                {
                    restoMONETI++;
                    restoST -= 200;

                }
                else if (restoST >= 100)
                {
                    restoMONETI++;
                    restoST -= 100;
                }
                else if (restoST >= 50)
                {
                    restoMONETI++;
                    restoST -= 50;
                }
                else if (restoST >= 20)
                {
                    restoMONETI++;
                    restoST -= 20;
                }
                else if (restoST >= 10)
                {
                    restoMONETI++;
                    restoST -= 10;
                }
                else if (restoST >= 5)
                {
                    restoMONETI++;
                    restoST -= 5;
                }
                else if (restoST >= 2)
                {
                    restoMONETI++;
                    restoST -= 2;
                }
                else if (restoST >= 1)
                {
                    restoMONETI++;
                    restoST -= 2;
                }
                else
                {
                    break;
                }
                
            }
            Console.WriteLine(restoMONETI);
        }
    }
}