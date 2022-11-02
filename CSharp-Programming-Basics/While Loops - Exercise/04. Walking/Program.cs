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
            string input = "";
            int stepsToHome = 0;
            int sumSteps = 0;
            int stepsMore = 0;
            int stepsLeft = 0;
            int steps = 0;

            while (true)
            {
                input = Console.ReadLine();
                if (input != "Going home")
                {
                    steps = Convert.ToInt32(input);
                    sumSteps += steps;
                }                
                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    steps = Convert.ToInt32(input);
                    sumSteps += steps;
                    stepsLeft = sumSteps - 10000;
                    if (sumSteps >= 10000)
                    {
                        stepsMore = 10000 - sumSteps;
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine("{0} steps over the goal!", Math.Abs(stepsMore));
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} more steps to reach goal.", Math.Abs(stepsLeft));
                        break;
                    }                                    
                }
                if (sumSteps >= 10000)
                {
                    stepsMore = 10000 - sumSteps;
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine("{0} steps over the goal!", Math.Abs(stepsMore));
                    break;
                }
            }
        }
    }
}