using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (input != "END")
            {
                if (input == "ListAll")
                {
                    foreach (var key in phonebook.Keys)
                    {
                        Console.WriteLine("{0} -> {1}", key, phonebook[key]);
                    }
                }
                else
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
                }
                input = Console.ReadLine();
            }
        }
    }
}
