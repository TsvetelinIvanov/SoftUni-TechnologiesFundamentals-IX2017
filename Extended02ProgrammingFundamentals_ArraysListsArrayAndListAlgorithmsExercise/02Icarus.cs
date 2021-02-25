using System;
using System.Linq;

namespace _02Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plane = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int startPosition = int.Parse(Console.ReadLine());
            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int damage = 1;
            while (command[0] != "Supernova")
            {                
                string direction = command[0];
                int stepsCount = int.Parse(command[1]);
                if (direction == "left")
                {
                    for (int i = stepsCount; i > 0; i--)
                    {
                        if (startPosition == 0)
                        {
                            startPosition = plane.Length - 1;
                            damage++;
                            plane[startPosition] -= damage;
                            continue;
                        }

                        startPosition--;
                        plane[startPosition] -= damage;
                    }
                }
                else if (direction == "right")
                {
                    while (stepsCount-- > 0)//== while (steps > 0) steps--;
                    {
                        if (startPosition == plane.Length - 1)
                        {
                            startPosition = 0;
                            damage++;
                            plane[startPosition] -= damage;
                            continue;
                        }

                        startPosition++;
                        plane[startPosition] -= damage;
                    }
                }

                command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine(string.Join(" ", plane));
        }
    }
}
