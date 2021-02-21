using System;
using System.Linq;
using System.Text;

namespace _06SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sum = new StringBuilder("");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string first = string.Empty;
            string second = string.Empty;

            if (firstNumber[0] == '0' || secondNumber[0] == '0')
            {
                first = firstNumber.TrimStart(new char[] { '0' });
                second = secondNumber.TrimStart(new char[] { '0' });
                firstNumber = first;
                secondNumber = second;
            }

            if (firstNumber.Length > secondNumber.Length)
            {
                int diference = firstNumber.Length - secondNumber.Length;
                secondNumber = new string('0', diference) + secondNumber;
            }
            else if (secondNumber.Length > firstNumber.Length)
            {
                int diference = secondNumber.Length - firstNumber.Length;
                firstNumber = new string('0', diference) + firstNumber;
            }

            int reminder = 0;
            for (int i = secondNumber.Length - 1; i >= 0; i--)
            {
                int sumNumbers = Convert.ToInt32(firstNumber[i] - '0')
                    + Convert.ToInt32(secondNumber[i] - '0') + reminder;
                if (sumNumbers < 10)
                {
                    sum.Append(sumNumbers);
                    reminder = 0;
                }
                else
                {
                    if (i != 0)
                    {
                        if (Convert.ToInt32(firstNumber[i] - '0')
                            + Convert.ToInt32(secondNumber[i] - '0') + reminder == 10)
                        {
                            sum.Append('0');
                            reminder = 1;
                        }
                        else
                        {
                            sum.Append(sumNumbers - 10);
                            reminder = 1;
                        }
                    }
                    else
                    {
                        sum.Append(string.Join("", Convert.ToString(Convert.ToUInt32(firstNumber[i] - '0')
                            + Convert.ToUInt32(secondNumber[i] - '0') + reminder).Reverse()));
                    }
                }
            }

            Console.WriteLine(String.Join("", sum.ToString().Reverse()));
        }
    }
}
