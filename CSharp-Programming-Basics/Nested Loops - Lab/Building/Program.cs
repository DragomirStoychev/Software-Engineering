using System;

namespace SoftUni
{
    class Program
    {
        static void Main()
        {
            int floar = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            int a = 0;
            int o = 0;
            int l = 0;

            for (int i = floar; i >= 1 ; i--)
            {
                if (i % 2 == 0)
                {
                    if (i == floar)
                    {
                        for (int y = 0; y < rooms; y++)
                        {
                            Console.Write($"L{i}{y} ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int y = 0; y < rooms; y++)
                        {
                            Console.Write($"O{i}{y} ");
                        }
                        Console.WriteLine();
                    }                    
                }
                else if (i % 2 != 0)
                {
                    if (i == floar)
                    {
                        for (int y = 0; y < rooms; y++)
                        {
                            Console.Write($"L{i}{y} ");
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int x = 0; x < rooms; x++)
                        {
                            Console.Write($"A{i}{x} ");
                        }
                        Console.WriteLine();
                    }                        
                }
            }
        }
    }
}