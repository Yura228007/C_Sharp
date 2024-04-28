using System;

public interface IMovable
{
    bool Move(int chance);
}

public interface INamed
{
    string Name { get; set; }
}

public abstract class Vehicle : IMovable, INamed
{
    protected string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Vehicle(string name)
    {
        this.name = name;
    }

    public virtual bool Move(int chance)
    {
        return chance > 50;
    }

    public abstract override string ToString();
}

public abstract class Car : Vehicle
{
    public Car(string name) : base(name) { }
}

public abstract class Truck : Vehicle
{
    public Truck(string name) : base(name) { }
}

public class Solaris : Car
{
    public Solaris(string name) : base(name) { }

    public override string ToString()
    {
        Random random = new Random();
        return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
    }
}

public class Rio : Car
{
    public Rio(string name) : base(name) { }

    public override string ToString()
    {
        Random random = new Random();
        return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
    }
}

public class Kamaz : Truck
{
    public Kamaz(string name) : base(name) { }

    public override string ToString()
    {
        Random random = new Random();
        return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
    }
}

public class Vaz : Truck
{
    public Vaz(string name) : base(name) { }

    public override string ToString()
    {
        Random random = new Random();
        return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solaris solaris = new Solaris("Solaris");
        Rio rio = new Rio("Rio");
        Kamaz kamaz = new Kamaz("Kamaz");
        Vaz vaz = new Vaz("Vaz");

        Console.WriteLine(solaris.ToString());
        Console.WriteLine(rio.ToString());
        Console.WriteLine(kamaz.ToString());
        Console.WriteLine(vaz.ToString());
        Console.ReadKey();
    }
}
