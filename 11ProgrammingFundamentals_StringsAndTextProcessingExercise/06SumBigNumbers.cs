using System;
using System.Linq;
using System.Text;

namespace _06SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sumBuilder = new StringBuilder("");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            
            if (firstNumber[0] == '0' || secondNumber[0] == '0')
            {
                string first = string.Empty;
                string second = string.Empty;
                first = firstNumber.TrimStart(new char[] { '0' });
                second = secondNumber.TrimStart(new char[] { '0' });
                firstNumber = first;
                secondNumber = second;
            }

            if (firstNumber.Length > secondNumber.Length)
            {
                int lengthDiference = firstNumber.Length - secondNumber.Length;
                secondNumber = new string('0', lengthDiference) + secondNumber;
            }
            else if (secondNumber.Length > firstNumber.Length)
            {
                int lengthDiference = secondNumber.Length - firstNumber.Length;
                firstNumber = new string('0', lengthDiference) + firstNumber;
            }

            int reminder = 0;
            for (int i = secondNumber.Length - 1; i >= 0; i--)
            {
                int digitsSum = Convert.ToInt32(firstNumber[i] - '0') + Convert.ToInt32(secondNumber[i] - '0') + reminder;
                if (digitsSum < 10)
                {
                    sumBuilder.Append(digitsSum);
                    reminder = 0;
                }
                else
                {
                    if (i != 0)
                    {
                        if (Convert.ToInt32(firstNumber[i] - '0') + Convert.ToInt32(secondNumber[i] - '0') + reminder == 10)
                        {
                            sumBuilder.Append('0');
                            reminder = 1;
                        }
                        else
                        {
                            sumBuilder.Append(digitsSum - 10);
                            reminder = 1;
                        }
                    }
                    else
                    {
                        sumBuilder.Append(string.Join("", Convert.ToString(Convert.ToUInt32(firstNumber[i] - '0') + Convert.ToUInt32(secondNumber[i] - '0') + reminder).Reverse()));
                    }
                }
            }

            Console.WriteLine(String.Join("", sumBuilder.ToString().Reverse()));
        }
    }
}
