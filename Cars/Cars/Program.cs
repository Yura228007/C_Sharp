using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Vehicle
{
    public abstract bool Move(int chance);
}

public abstract class Car : Vehicle
{
    public override bool Move(int chance)
    {
        Random random = new Random();
        chance = random.Next(1, 101);
        return chance <= 80; 
    }
}

public abstract class Truck : Vehicle
{
    public override bool Move(int chance)
    {
        Random random = new Random();
        chance = random.Next(1, 101);
        return chance <= 90; 
    }
}

public class Solaris : Car
{
    public override string ToString()
    {
        return "Solaris едет";
    }
}

public class Rio : Car
{
    public override string ToString()
    {
        return "Rio едет";
    }
}

public class Kamaz : Truck
{
    public override string ToString()
    {
        return "Kamaz едет";
    }
}

public class Vaz : Truck
{
    public override string ToString()
    {
        return "Vaz едет";
    }
} 

namespace Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
