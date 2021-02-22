using System;
using System.Linq;
using System.Text;

namespace _07MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            number = string.Join("", number.Reverse());

            StringBuilder resultBuilder = new StringBuilder();
            int current = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int next = 0;
                current += (number[i] - 48) * multiplier;
                if (current >= 10)
                {
                    next = current / 10;
                    current %= 10;
                }

                resultBuilder.Append(current);
                current = next;
            }

            if (current != 0)
            {
                resultBuilder.Append(current.ToString());
            }

            string finalNumberString = string.Join("", resultBuilder.ToString().TrimEnd('0').Reverse());
            Console.WriteLine(finalNumberString.Length != 0 ? finalNumberString : "0");
        }
    }
}
