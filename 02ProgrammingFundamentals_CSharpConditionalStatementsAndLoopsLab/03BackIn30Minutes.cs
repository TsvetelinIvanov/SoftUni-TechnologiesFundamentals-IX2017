using System;

namespace _03BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 30;
            if (minute > 59)
            {
                hour++;
                minute -= 60;
            }
            
            if (hour > 23)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{minute:d2}");
        }
    }
}
