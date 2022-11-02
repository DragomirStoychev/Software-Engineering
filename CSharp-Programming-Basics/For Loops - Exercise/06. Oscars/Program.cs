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
            decimal academyPoints = decimal.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string evaluator = "";

            decimal evaluatorPoints = 0;
            decimal evaluation = 0;

            for (int i = 0; i < n; i++)
            {
                evaluator = Console.ReadLine();
                decimal evaluatorChar = 0;
                evaluatorPoints = decimal.Parse(Console.ReadLine());
                for (int x = 0; x < evaluator.Length; x++)
                {
                    evaluatorChar++;
                }
                evaluation = academyPoints + ((evaluatorChar * evaluatorPoints) / 2);
                academyPoints = evaluation;
                if (evaluation >= 1250.5m)
                {
                    Console.WriteLine("Congratulations, {0} got a nominee for leading role with {1:f1}!", name, evaluation);
                    return;
                }
            }
            if (evaluation < 1250.5m)
            {
                Console.WriteLine("Sorry, {0} you need {1:f1} more!", name, Math.Abs(evaluation - 1250.5m));
            }
        }
    }
}