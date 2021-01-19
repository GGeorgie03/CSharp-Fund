using System;

namespace Problem_1._Activation_Keys2
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Generate")
            {
                string[] commands = input
                      .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];

                if (command == "Contains")
                {
                    if (key.Contains(commands[1]))
                    {
                        Console.WriteLine($"{key} contains {commands[1]}");
                        
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string cases = commands[1];
                    int startIndex = int.Parse(commands[2]);
                    int endIndex = int.Parse(commands[3]);
                    string temp = string.Empty;
                    string start = string.Empty;

                    if (cases == "Upper")
                    {
                        temp = key.Substring(startIndex, endIndex-startIndex).ToUpper();
                        start += key.Substring(0, startIndex);
                        start += temp;
                        start += key.Substring(endIndex);
                        key = start;
                        Console.WriteLine(key);
                        temp = string.Empty;
                        start = string.Empty;
                    }
                    else if (cases == "Lower")
                    {
                        temp = key.Substring(startIndex, endIndex-startIndex).ToLower();
                        start += key.Substring(0, startIndex);
                        start += temp;
                        start += key.Substring(endIndex);
                        key = start;
                        Console.WriteLine(key);
                        temp = string.Empty;
                        start = string.Empty;
                    }
                   

                }
                else if (command == "Slice")
                {
                    int slice1 = int.Parse(commands[1]);
                    int slice2 = int.Parse(commands[2]);
                    int lenght = slice2 - slice1;

                    key = key.Remove(slice1, lenght);
                    Console.WriteLine(key);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
