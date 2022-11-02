using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combos = 0;
            int sum; //по-късно се дава същата стойност и затова не е нужно да се инициализира

            for (int i = startNumber; i <= endNumber; i++) //*** е по-малък от ***, а не обратното
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    sum = i + j;//не ***-ваше сумата
                    combos++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combos} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combos} combinations - neither equals {magicNumber}");
        }
    }
}