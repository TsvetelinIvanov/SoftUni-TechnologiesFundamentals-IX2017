using System.Collections.Generic;
using System.IO;

namespace _06FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader("input.txt");
            using (streamReader)
            {
                Dictionary<string, string> emails = new Dictionary<string, string>();
                string emailName = streamReader.ReadLine();
                while (emailName != "stop")
                {
                    string email = streamReader.ReadLine();
                    if (!emails.ContainsKey(emailName) && !email.EndsWith("us") && !email.EndsWith("uk"))
                    {
                        emails[emailName] = email;
                    }

                    emailName = streamReader.ReadLine();
                }

                string output = string.Empty;
                foreach (KeyValuePair<string, string> item in emails)
                {
                    output += $"{item.Key} -> {item.Value}\r\n";
                }

                File.WriteAllText("output.txt", output);
            }
        }
    }
}
