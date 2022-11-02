using System;
namespace ConditionalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForTrip = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spentDays = 0; // каунт дните, в които харчи

            while (true)
            {
                string toDo = Console.ReadLine();
                double moneyToSpend = double.Parse(Console.ReadLine());
                days++;
                if (toDo == "save")
                {
                    currentMoney = moneyToSpend + currentMoney;
                    spentDays = 0; // Ако спестява го нулираме(5 последователни)
                }
                else if (toDo == "spend") // Няма нужда от допълнителната проверка. 
                {
                    currentMoney = currentMoney - moneyToSpend;
                    spentDays++; // Ако харчи го увеличаваме
                }
                if (currentMoney < 0)
                {
                    currentMoney = 0;
                }
                if (spentDays == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{days}");
                    break;
                }
                else if (currentMoney >= moneyNeededForTrip)
                {
                    Console.WriteLine($"You saved the money for {days} days.");
                    break;
                }

            }
        }
    }
}