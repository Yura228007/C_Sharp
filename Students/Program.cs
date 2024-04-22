using StudentNamespace;
using System;

namespace StudentNamespace
{
    public struct Grades
    {
        public int[] Programming;
        public int[] Administration;
        public int[] Design;
    }

    public class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Group { get; set; }
        public int Age { get; set; }
        public Grades StudentGrades;

        public Student(string surname, string name, string patronymic, string group, int age)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            Group = group;
            Age = age;
            StudentGrades = new Grades();
        }

        public void SetGrade(string subject, int[] grades)
        {
            switch (subject.ToLower())
            {
                case "programming":
                    StudentGrades.Programming = grades;
                    break;
                case "administration":
                    StudentGrades.Administration = grades;
                    break;
                case "design":
                    StudentGrades.Design = grades;
                    break;
                default:
                    Console.WriteLine("Invalid subject");
                    break;
            }
        }

        public int[] GetGrade(string subject)
        {
            switch (subject.ToLower())
            {
                case "programming":
                    return StudentGrades.Programming;
                case "administration":
                    return StudentGrades.Administration;
                case "design":
                    return StudentGrades.Design;
                default:
                    Console.WriteLine("Invalid subject");
                    return null;
            }
        }

        public double GetAverageGrade(string subject)
        {
            int[] grades = GetGrade(subject);
            if (grades == null || grades.Length == 0)
            {
                return 0;
            }

            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            return sum / grades.Length;
        }

        public void PrintStudentData()
        {
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Patronymic: {Patronymic}");
            Console.WriteLine($"Group: {Group}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Average Programming Grade: {GetAverageGrade("programming")}");
            Console.WriteLine($"Average Administration Grade: {GetAverageGrade("administration")}");
            Console.WriteLine($"Average Design Grade: {GetAverageGrade("design")}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create a new Student object
        Student student1 = new Student("Ivanov", "Ivan", "Ivanovich", "CS101", 20);

        // Set grades for the student
        student1.SetGrade("programming", new int[] { 85, 90, 95 });
        student1.SetGrade("administration", new int[] { 80, 85, 90 });
        student1.SetGrade("design", new int[] { 75, 80, 85 });

        // Print student data
        student1.PrintStudentData();

        // Print average grades
        Console.WriteLine($"Average Programming Grade: {student1.GetAverageGrade("programming")}");
        Console.WriteLine($"Average Administration Grade: {student1.GetAverageGrade("administration")}");
        Console.WriteLine($"Average Design Grade: {student1.GetAverageGrade("design")}");
    }
}
