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
            int tabs = int.Parse(Console.ReadLine());
            decimal salary = int.Parse(Console.ReadLine());
            string sait = "";
            
            for (int i = 0; i < tabs; i++)
            {
                sait = Console.ReadLine();

                if (sait == "Facebook")
                {
                    salary -= 150;
                }
                else if (sait == "Instagram")
                {
                    salary -= 100;
                }
                else if (sait == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine("{0}", salary);
        }
    }
}