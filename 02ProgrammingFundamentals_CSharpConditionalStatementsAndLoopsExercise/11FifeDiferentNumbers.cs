using System;

namespace _11FifeDiferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            bool isCondition = false;
            for (int n1 = start; n1 <= end; n1++)
            {
                for (int n2 = start; n2 <= end; n2++)
                {
                    for (int n3 = start; n3 <= end; n3++)
                    {
                        for (int n4 = start; n4 <= end; n4++)
                        {
                            for (int n5 = start; n5 <= end; n5++)
                            {
                                if (n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5)
                                {
                                    Console.WriteLine("{0} {1} {2} {3} {4}", n1, n2, n3, n4, n5);
                                    isCondition = true;
                                }
                            }
                        }
                    }
                }
            }
            
            if (!isCondition)
            {
                Console.WriteLine("No");
            }
        }
    }
}
