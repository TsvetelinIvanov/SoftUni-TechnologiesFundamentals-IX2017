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
            int[] ladybugIndices = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < ladybugIndices.Length; j++)
                {
                    if (i == ladybugIndices[j])
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
                long moveLength = long.Parse(command[2]);
                if (ladybugIndex < 0 || ladybugIndex >= field.Length || field[ladybugIndex] == 0 || moveLength == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0;
                if (direction == "right")
                {
                    if (ladybugIndex + moveLength < 0 || ladybugIndex + moveLength >= field.Length)
                    {
                        continue;
                    }

                    if (field[ladybugIndex + moveLength] == 0)
                    {
                        field[ladybugIndex + moveLength] = 1;
                    }
                    else
                    {
                        long step = moveLength;
                        while (field[ladybugIndex + moveLength] == 1)
                        {
                            if (moveLength > 0)
                            {
                                moveLength += step;
                            }                                
                            else
                            {
                                moveLength -= step;
                            }                                

                            if (ladybugIndex + moveLength > field.Length - 1 || ladybugIndex + moveLength < 0)
                            {
                                break;
                            }                                
                        }

                        if (ladybugIndex + moveLength > field.Length - 1 || ladybugIndex + moveLength < 0)
                        {
                            continue;
                        }                            

                        if (field[ladybugIndex + moveLength] == 0)
                        {
                            field[ladybugIndex + moveLength] = 1;
                        }
                    }
                }
                else if (direction == "left")
                {
                    if (ladybugIndex - moveLength < 0 || ladybugIndex - moveLength >= field.Length)
                    {
                        continue;
                    }

                    if (field[ladybugIndex - moveLength] == 0)
                    {
                        field[ladybugIndex - moveLength] = 1;
                    }
                    else
                    {
                        long step = moveLength;
                        while (field[ladybugIndex - moveLength] == 1)
                        {
                            if (moveLength > 0)
                            {
                                moveLength += step;
                            }                               
                            else
                            {
                                moveLength -= step;
                            }                                

                            if (ladybugIndex - moveLength > field.Length - 1 || ladybugIndex - moveLength < 0)
                            {
                                break;
                            }                                
                        }

                        if (ladybugIndex - moveLength > field.Length - 1 || ladybugIndex - moveLength < 0)
                        {
                            continue;
                        }                            

                        if (field[ladybugIndex - moveLength] == 0)
                        {
                            field[ladybugIndex - moveLength] = 1;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
