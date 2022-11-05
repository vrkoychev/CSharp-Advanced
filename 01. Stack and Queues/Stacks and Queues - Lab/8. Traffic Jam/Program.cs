using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string car = Console.ReadLine();

            int passedCars = 0;
            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }

                        string currCar = cars.Dequeue();
                        passedCars++;
                        Console.WriteLine($"{currCar} passed!");
                    }
                }
                else
                {
                    cars.Enqueue(car);
                }

                car = Console.ReadLine();
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
