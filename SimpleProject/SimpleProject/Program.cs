using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using school;
namespace SimpleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            int[] arrayInt = { 5, 34, 67, 12, 94, 42 };
                        IEnumerable<int> query = from i in arrayInt
                                                 where i > 20 && i <50
                                                 orderby i ascending
                                                 select i;
                        WriteLine("Only the even elements:");
                        foreach (int item in query)
                        {
                            Write($"{item}\t");
                        }
                        WriteLine();
                        System.Console.ReadKey();*/

            List<Student> students = new List<Student> {
                new Student("Mark", 3),
                new Student("Bob", 4),
                new Student("Tom", 2),
                new Student("Ginger", 4),
                new Student("Yura", 5),
                new Student("Nikita", 2)
            };

            IEnumerable<Student> queryH = from student in students
                                          where (student.mark > 4) && (student.went = false)
                                          orderby student.mark descending
                                          select student;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"day {i+1}");

                if (queryH.Count() > 0)
                {

                }
            }

        }
    }
}