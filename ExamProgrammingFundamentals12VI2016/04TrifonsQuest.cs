using System;
using System.Linq;

namespace _04TrifonsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            long health = long.Parse(Console.ReadLine());
            int[] dimensions = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rowsCount = dimensions[0];
            int colsCount = dimensions[1];
            
            char[][] map = new char[rowsCount][];
            int row = 0;
            int col = 0;
            int turnsCount = 0;
            
            for (int i = 0; i < rowsCount; i++)
            {
                map[i] = Console.ReadLine().ToCharArray();
            }

            for (int i = 0; i < colsCount; i++)
            {
                for (int j = i % 2 == 0 ? 0 : rowsCount - 1; j < rowsCount && j >= 0; j = i % 2 == 0 ? j + 1 : j - 1)
                {
                    switch (map[j][i])
                    {
                        case 'F':
                            health -= turnsCount / 2;
                            if (health <= 0)
                            {
                                row = j;
                                col = i;
                                break;
                            }

                            turnsCount++;
                            break;
                        case 'H':
                            health += turnsCount / 3;
                            turnsCount++;
                            break;
                        case 'T':
                            turnsCount += 2;
                            turnsCount++;
                            break;
                        case 'E':
                            turnsCount++;
                            break;
                    }

                    if (health <= 0)
                    {
                        break;
                    }
                }

                if (health <= 0)
                {
                    break;
                }
            }

            if (health > 0)
            {
                Console.WriteLine("Quest completed!");
                Console.WriteLine("Health: " + health);
                Console.WriteLine("Turns: " + turnsCount);
            }
            else
            {
                Console.WriteLine($"Died at: [{row}, {col}]");
            }
        }        
    }
}
