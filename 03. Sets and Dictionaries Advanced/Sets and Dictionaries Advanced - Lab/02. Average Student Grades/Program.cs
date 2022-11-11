using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                string name = data[0];
                decimal grade = decimal.Parse(data[1]);

                if (studentsGrades.ContainsKey(name))
                {
                    foreach (var st in studentsGrades)
                    {
                        if (st.Key == name)
                        {
                            st.Value.Add(grade);
                        }
                    }
                }
                else
                {
                    List<decimal> grades = new List<decimal>();
                    grades.Add(grade);
                    studentsGrades.Add(name, grades);
                }
            }

            foreach (var student in studentsGrades)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:F2} ");
                }

                Console.Write($"(avg: {student.Value.Average():F2})");
                Console.WriteLine();
            }
        }
    }
}
