using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program_FileStream
{
    internal class Program
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Class { get; set; }

            public Student(string firstName, string lastName, string studentClass)
            {
                FirstName = firstName;
                LastName = lastName;
                Class = studentClass;
            }

            public override string ToString()
            {
                return $"{FirstName}, {LastName}, {Class}";
            }
        }
        static void Main(string[] args)
        {
            using (FileStream fileStream = new FileStream("TEMPFILE.txt", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                writer.Write("Hello World!");
                }
            }
            using (FileStream fileStream = new FileStream("TEMPFILE.bin", FileMode.Create))
            {
                using (BinaryWriter writer = new BinaryWriter(fileStream))
                {
                    writer.Write(10);
                    writer.Write(20.5);
                    writer.Write("Hello World!");
                }
            }
            Student student1 = new Student("Mark", "Poor", "D1");
            using (FileStream fileStream = new FileStream("TEMPFILE.txt", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(fileStream))
                {
                    writer.Write(student1.ToString() + "\n");
                }
            }

            using (FileStream fs = new FileStream("Student.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    Console.WriteLine(sr.ReadToEnd()); 
                }
            }
            Console.ReadKey();
        }
    }
}
