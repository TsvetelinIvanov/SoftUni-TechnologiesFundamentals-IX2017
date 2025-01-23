using System;
using System.Linq;

namespace _02Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            int[] ladybugIndexes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < ladybugIndexes.Length; j++)
                {
                    if (i == ladybugIndexes[j])
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commandLine = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(commandLine[0]);
                string direction = commandLine[1];
                long movesCount = long.Parse(commandLine[2]);

                if (ladybugIndex < 0 || ladybugIndex >= field.Length || field[ladybugIndex] == 0 || movesCount == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;
                if (direction == "right")
                {

                    if (ladybugIndex + movesCount < 0 || ladybugIndex + movesCount >= field.Length)
                    {
                        continue;
                    }

                    if (field[ladybugIndex + movesCount] == 0)
                    {
                        field[ladybugIndex + movesCount] = 1;
                    }
                    else
                    {
                        long step = movesCount;
                        while (field[ladybugIndex + movesCount] == 1)
                        {
                            if (movesCount > 0)
                            {
                                movesCount += step;
                            }
                            else
                            {
                                movesCount -= step;
                            }                                

                            if (ladybugIndex + movesCount > field.Length - 1 || ladybugIndex + movesCount < 0)
                            {
                                break;
                            }                                
                        }

                        if (ladybugIndex + movesCount > field.Length - 1 || ladybugIndex + movesCount < 0)
                        {
                            continue;
                        }                            

                        if (field[ladybugIndex + movesCount] == 0)
                        {
                            field[ladybugIndex + movesCount] = 1;
                        }                        
                    }
                }
                else if (direction == "left")
                {

                    if (ladybugIndex - movesCount < 0 || ladybugIndex - movesCount >= field.Length)
                    {
                        continue;
                    }

                    if (field[ladybugIndex - movesCount] == 0)
                    {
                        field[ladybugIndex - movesCount] = 1;
                    }
                    else
                    {
                        long step = movesCount;
                        while (field[ladybugIndex - movesCount] == 1)
                        {                            
                            if (movesCount > 0)
                            {
                                movesCount += step;
                            }
                            else
                            {
                                movesCount -= step;
                            }                                

                            if (ladybugIndex - movesCount > field.Length - 1 || ladybugIndex - movesCount < 0)
                            {
                                break;
                            }                                
                        }

                        if (ladybugIndex - movesCount > field.Length - 1 || ladybugIndex - movesCount < 0)
                        {
                            continue;
                        }                            

                        if (field[ladybugIndex - movesCount] == 0)
                        {
                            field[ladybugIndex - movesCount] = 1;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
