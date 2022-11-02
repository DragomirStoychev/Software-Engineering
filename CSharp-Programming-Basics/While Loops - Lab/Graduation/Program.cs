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
            string name = Console.ReadLine();
            double grade = 0;
            double averageGrade = 0;
            double classes = 0;
            int skysana = 0;

            while (classes < 12)
            {
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                classes++;
                if (grade < 4)
                {
                    skysana++;
                }
                if (skysana > 1)
                {
                    Console.WriteLine("{0} has been excluded at {1} grade",name , --classes);
                    break;
                }
                if (skysana <= 1 && classes == 12)
                {
                    Console.WriteLine("{0} graduated. Average grade: {1:f2}", name, averageGrade / classes);
                }                
            }           
        }
    }
}