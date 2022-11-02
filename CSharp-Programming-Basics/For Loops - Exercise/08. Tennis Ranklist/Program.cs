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
            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            int sumPoints = 0;
            int pointPerTournament = 0;
            double averagePoints = 0;
            double win = 0;
            double winSum = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string final = Console.ReadLine();
                switch (final)
                {
                    case "W":
                        pointPerTournament += 2000;
                        win++;
                        break;
                    case "F":
                        pointPerTournament += 1200;
                        break;
                    case "SF":
                        pointPerTournament += 720;
                        break;
                }
                sumPoints = startPoints + pointPerTournament;
                averagePoints = pointPerTournament / tournaments;
                winSum = (win / tournaments) * 100.0;
            }
            Console.WriteLine("Final points: {0}",sumPoints);
            Console.WriteLine("Average points: {0}", Math.Floor(averagePoints));
            Console.WriteLine("{0:f2}%", winSum);
        }
    }
}