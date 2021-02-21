using System;
using System.Collections.Generic;

namespace _04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string emailName = Console.ReadLine();
            while (emailName != "stop")
            {
                string email = Console.ReadLine();
                if (!emails.ContainsKey(emailName) && !email.EndsWith("us") && !email.EndsWith("uk"))
                {
                    emails[emailName] = email;
                }

                emailName = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> email in emails)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");
            }
        }
    }
}
