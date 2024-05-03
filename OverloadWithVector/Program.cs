using System;

public class Vector
{
    public double X { get; set; }
    public double Y { get; set; }

    public Vector(double x, double y)
    {
        X = x;
        Y = y;
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y);
    }

    public static Vector operator -(Vector v1, Vector v2)
    {
        return new Vector(v1.X - v2.X, v1.Y - v2.Y);
    }

    public static Vector operator *(Vector v, int n)
    {
        return new Vector(v.X * n, v.Y * n);
    }

    public static Vector operator /(Vector v, int n)
    {
        return new Vector(v.X / n, v.Y / n);
    }

    public static bool operator ==(Vector v1, Vector v2)
    {
        return v1.X == v2.X && v1.Y == v2.Y;
    }

    public static bool operator !=(Vector v1, Vector v2)
    {
        return !(v1 == v2);
    }

    public static bool operator true(Vector v)
    {
        return v.X != 0 || v.Y != 0;
    }

    public static bool operator false(Vector v)
    {
        return v.X == 0 && v.Y == 0;
    }

    public static implicit operator Vector(double angle)
    {
        return new Vector(Math.Cos(angle), Math.Sin(angle));
    }

    public static explicit operator double(Vector v)
    {
        return Math.Atan2(v.Y, v.X);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Vector v = (Vector)obj;
        return X == v.X && Y == v.Y;
    }

    public override int GetHashCode()
    {
        return Tuple.Create(X, Y).GetHashCode();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vector v1 = new Vector(1, 2);
        Vector v2 = new Vector(3, 4);

        Vector v3 = v1 + v2;
        Console.WriteLine($"v1 + v2 = ({v3.X}, {v3.Y})");

        Vector v4 = v1 - v2;
        Console.WriteLine($"v1 - v2 = ({v4.X}, {v4.Y})");

        Vector v5 = v1 * 2;
        Console.WriteLine($"v1 * 2 = ({v5.X}, {v5.Y})");

        Vector v6 = v1 / 2;
        Console.WriteLine($"v1 / 2 = ({v6.X}, {v6.Y})");

        Console.WriteLine($"v1 == v2: {v1 == v2}");
        Console.WriteLine($"v1 != v2: {v1 != v2}");

        if (v1)
        {
            Console.WriteLine("v1 is not zero");
        }
        else
        {
            Console.WriteLine("v1 is zero");
        }

        double angle = Math.PI / 4; // 45 degrees
        Vector v7 = angle;
        Console.WriteLine($"angle to vector = ({v7.X}, {v7.Y})");

        double angleFromVector = (double)v1;
        Console.WriteLine($"angle from vector = {angleFromVector}");

        Console.ReadKey();
    }
}
