using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        abstract class Human
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }
            public override string ToString()
            {
                return $"First Name: {FirstName}\nLast Name: {LastName}\nBirthday: {Birthday}\n";
            }
        }
        abstract class Employee : Human 
        {
            public string Position { get; set; }
            public double Salary { get; set; }
            public override string ToString()
            {
                return base.ToString()+$"Position: {Position}\nSalary: {Salary}";
            }
        }

        interface IWorker
        {
            bool IsWorking { get; }
            string Work();
        }

        interface IManager
        {
            List<IWorker> ListOfWorkers { get; set; }
            void GiveTasks();
            void CountingMoney();
            void CheckWork();
        }

        class Foreman  : Employee, IManager
        {
            public List<IWorker> ListOfWorkers { get; set; }

            public void GiveTasks()
            {
                Console.WriteLine("I give instructions to the workers");
            }

            public void CountingMoney()
            {
                Console.WriteLine("The day is over. We count the profit");
            }

            public void CheckWork()
            {
                Console.WriteLine("I need to check worker's job");
            }
        }

        class BuilderOfHouses : Employee, IWorker
        {
            bool isWorking = true;

            public bool IsWorking
            {
                get
                {
                    return isWorking;
                }
            }
            public string Work()
            {
                return ("I'm building the house");
            }
        }

        class Architect : Employee, IWorker
        {
            bool isWorking = true;

            public bool IsWorking
            {
                get
                {
                    return isWorking;
                }
            }
            public string Work()
            {
                return ("I'm painting the house");
            }
        }

        static void Main(string[] args)
        {
            Foreman foreman = new Foreman() { FirstName = "Tom", LastName = "Rich",
                Birthday = new DateTime(1983, 9, 3), Position = "Foreman", Salary = 240000 };
            IWorker builderOfHouses = new BuilderOfHouses() { FirstName = "Mike", LastName = "Mouse", 
                Birthday = new DateTime(1998,1,12), Position = "Builder", Salary = 80000 };
            if (foreman is Employee)
            {
                Console.WriteLine($"Salary of Boss: {(foreman as Employee).Salary}");
            }
            IWorker architect = new Architect() { FirstName = "Donatelo", LastName = "Turtle", 
                Birthday = new DateTime(2003, 4, 8), Position = "Painter", Salary = 100000 };
            foreman.ListOfWorkers = new List<IWorker> { builderOfHouses, architect};
            if (foreman is IManager)
            {
                foreman.CheckWork();
            }
            foreach (IWorker item in foreman.ListOfWorkers)
            {
                Console.WriteLine(item);
                if (item.IsWorking)
                {
                    Console.WriteLine(item.Work());
                }
            }
            Console.ReadKey();
        }
    }
}
