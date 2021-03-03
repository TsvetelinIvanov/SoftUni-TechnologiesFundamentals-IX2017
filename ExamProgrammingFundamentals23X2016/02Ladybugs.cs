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
            int[] ladybugIndexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
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
                string[] command = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int ladybugIndex = int.Parse(command[0]);
                string direction = command[1];
                long removal = long.Parse(command[2]);
                if (ladybugIndex < 0 || ladybugIndex >= field.Length || field[ladybugIndex] == 0
                    || removal == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;
                if (direction == "right")
                {
                    if (ladybugIndex + removal < 0 || ladybugIndex + removal >= field.Length)
                    {
                        continue;
                    }

                    if (field[ladybugIndex + removal] == 0)
                    {
                        field[ladybugIndex + removal] = 1;
                    }
                    else
                    {
                        long step = removal;
                        while (field[ladybugIndex + removal] == 1)
                        {
                            if (removal > 0)
                            {
                                removal += step;
                            }                                
                            else
                            {
                                removal -= step;
                            }                                

                            if (ladybugIndex + removal > field.Length - 1 || ladybugIndex + removal < 0)
                            {
                                break;
                            }                                
                        }

                        if (ladybugIndex + removal > field.Length - 1 || ladybugIndex + removal < 0)
                        {
                            continue;
                        }                            

                        if (field[ladybugIndex + removal] == 0)
                        {
                            field[ladybugIndex + removal] = 1;
                        }
                    }
                }
                else if (direction == "left")
                {
                    if (ladybugIndex - removal < 0 || ladybugIndex - removal >= field.Length)
                    {
                        continue;
                    }

                    if (field[ladybugIndex - removal] == 0)
                    {
                        field[ladybugIndex - removal] = 1;
                    }
                    else
                    {
                        long step = removal;
                        while (field[ladybugIndex - removal] == 1)
                        {
                            if (removal > 0)
                            {
                                removal += step;
                            }                               
                            else
                            {
                                removal -= step;
                            }                                

                            if (ladybugIndex - removal > field.Length - 1 || ladybugIndex - removal < 0)
                            {
                                break;
                            }                                
                        }

                        if (ladybugIndex - removal > field.Length - 1 || ladybugIndex - removal < 0)
                        {
                            continue;
                        }                            

                        if (field[ladybugIndex - removal] == 0)
                        {
                            field[ladybugIndex - removal] = 1;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
