using System.Collections.Generic;
using System.IO;

namespace _06FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");
            using (file)
            {
                Dictionary<string, string> emails = new Dictionary<string, string>();
                string emailName = file.ReadLine();
                while (emailName != "stop")
                {
                    string email = file.ReadLine();
                    if (!emails.ContainsKey(emailName) && !email.EndsWith("us") && !email.EndsWith("uk"))
                    {
                        emails[emailName] = email;
                    }

                    emailName = file.ReadLine();
                }

                string text = string.Empty;
                foreach (KeyValuePair<string, string> item in emails)
                {
                    text += $"{item.Key} -> {item.Value}\r\n";
                }

                File.WriteAllText("output.txt", text);
            }
        }
    }
}
