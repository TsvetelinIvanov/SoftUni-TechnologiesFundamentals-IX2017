using System;

namespace _16InstructionSetDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            string operationCode = Console.ReadLine();
            while (operationCode != "END")
            {
                string[] codeArguments = operationCode.Split(' ');
                long result = 0;
                switch (codeArguments[0])
                {
                    case "INC":
                    {
                        long operandOne = long.Parse(codeArguments[1]);
                        result = operandOne + 1;
                        break;
                    }
                    case "DEC":
                    {
                        long operandOne = long.Parse(codeArguments[1]);
                        result = operandOne - 1;
                        break;
                    }
                    case "ADD":
                    {
                        long operandOne = long.Parse(codeArguments[1]);
                        long operandTwo = long.Parse(codeArguments[2]);
                        result = operandOne + operandTwo;
                        break;
                    }
                    case "MLA":
                    {
                        long operandOne = long.Parse(codeArguments[1]);
                        long operandTwo = long.Parse(codeArguments[2]);
                        result = operandOne * operandTwo;
                        break;
                    }
                }
                
                Console.WriteLine(result);
                operationCode = Console.ReadLine();
            }
        }
    }
}
