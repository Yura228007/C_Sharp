using System;
using prog;

namespace CarProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car(3, "light");
            c.collision += (Car cur_car) => { Console.WriteLine(cur_car + "hitted!"); };

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("-");
                c.update(random.Next(1, 5));
            }
        }
    }
}
