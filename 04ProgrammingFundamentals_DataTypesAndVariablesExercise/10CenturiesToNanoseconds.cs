using System;

namespace _10CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            //it don't work for nanoseconds when centuries are more than five!
            //int centuries = int.Parse(Console.ReadLine());
            //int years = centuries * 100;
            //int days = (int)(years * 365.2422);
            //int hours = days * 24;
            //int minutes = hours * 60;
            //long seconds = (long)minutes * 60;
            //long milliseconds = seconds * 1000;
            //long microseconds = milliseconds * 1000;
            //ulong nanoseconds = (ulong)microseconds * 1000;

            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            ulong hours = (ulong)days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            decimal milliseconds = (decimal)seconds * 1000;
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
