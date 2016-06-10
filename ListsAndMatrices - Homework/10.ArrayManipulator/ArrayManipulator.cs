using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(Int32.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "print")
            {
                List<string> commands = command.Split(' ').ToList();
                string task = commands[0];
                commands.RemoveAt(0);

                switch (task)
                {
                    case "add":
                        input.Insert(Int32.Parse(commands[0]), Int32.Parse(commands[1]));
                        break;

                    case "remove":
                        input.RemoveAt(Int32.Parse(commands[0]));
                        break;

                    case "addMany":
                        int index = Int32.Parse(commands[0]);
                        commands.RemoveAt(0);
                        List<int> arrToAdd = commands.Select(Int32.Parse).ToList();
                        input.InsertRange(index, arrToAdd);
                        break;

                    case "contains":
                        int elementToSearch = Int32.Parse(commands[0]);
                        int counter = 0;
                        if (input.Contains(elementToSearch))
                        {
                            foreach (int num in input)
                            {
                                if (num == elementToSearch)
                                {
                                    Console.WriteLine(counter);
                                }
                                counter++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;

                    case "shift":
                        ShiftLeft(input, Int32.Parse(commands[0]));
                        break;


                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", input));
        }

        public static void ShiftLeft<T>(List<T> lst, int shifts)
        {
            for (int i = shifts; i < lst.Count; i++)
            {
                lst[i - shifts] = lst[i];
            }

            for (int i = lst.Count - shifts; i < lst.Count; i++)
            {
                lst[i] = default(T);
            }
        }
    }
}
