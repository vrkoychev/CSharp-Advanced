using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> numbers = new HashSet<string>();

            while (input != "END")
            {
                string[] data = input.Split(", ");

                string command = data[0];
                string carNumber = data[1];

                if (command == "IN")
                {
                    numbers.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    numbers.Remove(carNumber);
                }
                    input = Console.ReadLine();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
