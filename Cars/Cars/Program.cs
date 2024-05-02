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
        if (chance >= 30 && chance < 40)
        {
            throw new Exception($"{name} - спустилось колесо");
        }
        else if (chance >= 40 && chance < 50)
        {
            throw new Exception($"{name} - отказали тормоза");
        }
        else if (chance >= 20 && chance < 30)
        {
            throw new Exception($"{name} - разрядился двигатель");
        }
        else if (chance >= 0 && chance < 20)
        {
            throw new Exception($"{name} - зеркала сломаны");
        }
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
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
    }
}

public class Rio : Car
{
    public Rio(string name) : base(name) { }

    public override string ToString()
    {
        Random random = new Random();
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
    }
}

public class Kamaz : Truck
{
    public Kamaz(string name) : base(name) { }

    public override string ToString()
    {
        Random random = new Random();
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
    }
}

public class Vaz : Truck
{
    public Vaz(string name) : base(name) { }

    public override string ToString()
    {
        Random random = new Random();
        try
        {
            return Move(random.Next(100)) ? $"{name} is moving" : $"{name} is broken";
        }
        catch (Exception ex)
        {
            return $"{name} is broken - {ex.Message}";
        }
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
