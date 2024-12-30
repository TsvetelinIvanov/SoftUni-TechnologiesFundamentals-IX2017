using System;
using System.Linq;

namespace _18SequenceOfCommandsDebuggingExercise
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            long[] array = Console.ReadLine().Split(ArgumentsDelimiter).Select(long.Parse).ToArray();

            string[] commandArguments = Console.ReadLine().Split(' ').ToArray();
            while (commandArguments[0] != "stop")
            {
                int[] arguments = new int[2];
                if (commandArguments[0] == "add" || commandArguments[0] == "subtract" || commandArguments[0] == "multiply")
                {
                    arguments[0] = int.Parse(commandArguments[1]);
                    arguments[1] = int.Parse(commandArguments[2]);
                    
                    PerformAction(array, commandArguments[0], arguments);
                }
                else
                {
                    PerformAction(array, commandArguments[0], arguments);
                }

                PrintArray(array);
                Console.WriteLine();

                commandArguments = Console.ReadLine().Split(' ').ToArray();
            }
        }

        private static void PerformAction(long[] array, string action, int[] arguments)
        {

            int position = arguments[0];
            int value = arguments[1];
            switch (action)
            {
                case "multiply":
                    array[position - 1] *= value;
                    break;
                case "add":
                    array[position - 1] += value;
                    break;
                case "subtract":
                    array[position - 1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
            }
        }

         private static void ArrayShiftLeft(long[] array)
        {
            long number = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = number;
        }

        private static void ArrayShiftRight(long[] array)
        {
            long number = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = number;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
