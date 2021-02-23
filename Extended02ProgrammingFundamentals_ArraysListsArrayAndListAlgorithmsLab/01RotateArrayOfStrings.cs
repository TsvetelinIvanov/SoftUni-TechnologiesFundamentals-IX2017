using System;
using System.Linq;

namespace _01RotateArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] rotated = new string[array.Length];
            for (int i = 0; i < array.Length - 1; i++)
            {
                rotated[i + 1] = array[i];
            }

            string lastElement = array[array.Length - 1];
            rotated[0] = lastElement;
            Console.WriteLine(string.Join(" ", rotated));

            // if we wont to rotate more times:
            //string[] array = Console.ReadLine()
            //     .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //int rotations = int.Parse(Console.ReadLine());
            //for (int i = 0; i < rotations % array.Length; i++)
            //{
            //    string temp = array[array.Length - 1];
            //    for (int j = array.Length - 1; j >= 1; j--)
            //    {
            //        array[j] = array[j - 1];
            //    }

            //    array[0] = temp;
            //}

            //Console.WriteLine(string.Join(" ", array));
        }
    }
}
