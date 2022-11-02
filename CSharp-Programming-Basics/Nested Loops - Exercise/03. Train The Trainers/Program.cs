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
            double n = double.Parse(Console.ReadLine());
            string input = "";
            double grade = 0;
            double totalGrade = 0;
            double totalGrade2 = 0;
            int count = 0;

            while (input != "Finish")
            {
                input = Console.ReadLine();
                if (input == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {(totalGrade2 / count):f2}.");
                    return;
                }
                for (int i = 0; i < n; i++)
                {
                    grade = double.Parse((Console.ReadLine()));
                    count++;
                    totalGrade += grade;
                    totalGrade2 += grade;
                }
                Console.WriteLine($"{input} - {(totalGrade / n):f2}.");
                totalGrade = 0;
            }
        }
    }
}