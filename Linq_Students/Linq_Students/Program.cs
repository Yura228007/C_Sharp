using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public List<int> Marks { get; set; }
    public bool Went { get; set; }
    public bool Punished { get; set; }
}

public class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Student1", Marks = new List<int> { 5, 4, 3, 2, 1 }, Went = false, Punished = false },
            new Student { Name = "Student2", Marks = new List<int> { 2, 2, 2, 2, 2 }, Went = true, Punished = true },
            new Student { Name = "Student3", Marks = new List<int> { 5, 5, 5, 5, 5 }, Went = false, Punished = false },
            new Student { Name = "Student4", Marks = new List<int> { 3, 3, 3, 3, 3 }, Went = true, Punished = false },
            new Student { Name = "Student5", Marks = new List<int> { 4, 4, 4, 4, 4 }, Went = false, Punished = true }
        };

        for (int i = 0; i < 100; i++)
        {
            var excellentStudents = students.Where(s => s.Marks.Last() == 5 && !s.Went && !s.Punished).ToList();
            var punishedStudents = students.Where(s => s.Punished).ToList();
            var wentAndNotPunished = students.Where(s => s.Went && !s.Punished).ToList();
            var lastMarkTwo = students.Where(s => s.Marks.Last() == 2).ToList();

            Student studentToGoForWater;

            if (excellentStudents.Any())
            {
                studentToGoForWater = excellentStudents.First();
            }
            else
            {
                Random rand = new Random();
                studentToGoForWater = students[rand.Next(students.Count)];
            }

            if (wentAndNotPunished.Any() && wentAndNotPunished.First().Marks.Last() != 5)
            {
                wentAndNotPunished.First().Punished = true;
            }

            foreach (var student in punishedStudents)
            {
                student.Marks.Add(2);
            }

            studentToGoForWater.Went = true;
            studentToGoForWater.Marks.Add(studentToGoForWater.Marks.Last());

            if (i % 25 == 0)
            {
                foreach (var student in students)
                {
                    var average = student.Marks.Skip(Math.Max(0, student.Marks.Count() - 25)).Average();
                    Console.WriteLine($"Student: {student.Name}, Average for last 25 days: {average}");
                }
            }
        }

        foreach (var student in students)
        {
            var timesPunished = students.Count(s => s.Punished);
            var timesWentForWater = students.Count(s => s.Went);
            var averageMark = student.Marks.Average();

            Console.WriteLine($"Student: {student.Name}, Times Punished: {timesPunished}, Times Went for Water: {timesWentForWater}, Average Mark: {averageMark}");
        }

        Console.ReadKey();
    }
}
