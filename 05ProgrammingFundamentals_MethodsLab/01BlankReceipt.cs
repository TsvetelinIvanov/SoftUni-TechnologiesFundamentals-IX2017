using System;

namespace _01BlankReceipt
{
    class BlankReceipt
    {
        static void Main(string[] args)
        {
            //PrintReceipHeader();
            //PrintReceiptBody();
            //PrintReceipFooter();
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintReceipHeader();
            PrintReceiptBody();
            PrintReceipFooter();
        }

        static void PrintReceipHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintReceipFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(@"© SoftUni");
        }              
    }
}
