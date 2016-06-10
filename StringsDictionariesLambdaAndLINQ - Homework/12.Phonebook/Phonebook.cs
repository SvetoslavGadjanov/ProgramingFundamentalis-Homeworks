using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (input != "END")
            {
                string[] data = input.Split(' ').ToArray();

                switch (data[0])
                {
                    case "A":
                        if (phonebook.ContainsKey(data[1]))
                        {
                            phonebook[data[1]] = data[2];
                        }
                        else
                        {
                            phonebook.Add(data[1], data[2]);
                        }
                        break;
                    case "S":
                        if (phonebook.ContainsKey(data[1]))
                        {
                            foreach (var key in phonebook.Keys)
                            {
                                if (key == data[1])
                                {
                                    Console.WriteLine("{0} -> {1}", key, phonebook[key]);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Contact {0} does not exist.", data[1]);
                        }
                        break;
                }
                input = Console.ReadLine();
            }
        }
    }
}
