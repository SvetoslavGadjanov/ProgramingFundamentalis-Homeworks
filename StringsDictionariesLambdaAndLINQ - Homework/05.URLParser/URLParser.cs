using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.URLParser
{
    class URLParser
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string protocol = "";
            string server = "";
            string resource = "";

            if (input.Contains(@"://"))
            {
                input = input.Replace(@"://", " ");
                string[] firstSplit = input.Split(' ').ToArray();

                if (firstSplit.Length > 1)
                {
                    protocol = firstSplit[0];
                }


                List<string> secondSplit = firstSplit[1].Split('/').ToList();

                if (secondSplit.Count == 1)
                {
                    server = secondSplit[0];

                }
                else if (secondSplit.Count == 2)
                {
                    server = secondSplit[0];
                    resource = secondSplit[1];
                }
                else if (secondSplit.Count > 2)
                {
                    server = secondSplit[0];
                    secondSplit.RemoveAt(0);
                    resource = String.Join("/", secondSplit);
                }
            }
            else
            {
                server = input;
            }
            

            Console.WriteLine("[protocol] = \"{0}\"", protocol);
            Console.WriteLine("[server] = \"{0}\"", server);
            Console.WriteLine("[resource] = \"{0}\"", resource);


        }
    }
}
