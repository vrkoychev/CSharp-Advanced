using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuest = new HashSet<string>();

            bool isParty = false;
            while (input != "END")
            {
                if (input == "PARTY")
                {
                    isParty = true;
                    input = Console.ReadLine();
                    continue;
                }

                if (isParty)
                {
                    if (vipGuests.Contains(input))
                    {
                        vipGuests.Remove(input);
                    }
                    else if (regularGuest.Contains(input))
                    {
                        regularGuest.Remove(input);
                    }
                    input = Console.ReadLine();
                    continue;
                }

                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuest.Add(input);
                }

                input = Console.ReadLine();
            }

            int allGuest = vipGuests.Count + regularGuest.Count;

            Console.WriteLine(allGuest);

            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }

            foreach (var regular in regularGuest)
            {
                Console.WriteLine(regular);
            }
        }
    }
}
