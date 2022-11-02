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
            int age = int.Parse(Console.ReadLine());
            decimal priceLoundry = decimal.Parse(Console.ReadLine());
            decimal priceToy = decimal.Parse(Console.ReadLine());

            decimal birthDayMoney = 10;
            decimal savedMoney = 0;

            decimal toys = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += birthDayMoney;
                    savedMoney--;
                    birthDayMoney += 10;
                }
                else
                {
                    toys++;
                }
            }
            decimal total = savedMoney + (toys * priceToy);

            if (total >= priceLoundry)
            {
                Console.WriteLine("Yes! {0:f2}", total - priceLoundry);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(priceLoundry - total));
            }
        }
    }
}