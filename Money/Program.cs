using System;

public class Money
{
    public int grivnas; public int kopecks;
    public Money(int grivnas, int kopecks)
    {
        if (grivnas < 0 || kopecks < 0)
            throw new Exception("Банкрот"); this.grivnas = grivnas;
        this.kopecks = kopecks;
    }
    public static Money operator +(Money a, Money b)
    {
        int totalKopecks = a.kopecks + b.kopecks;
        int extraGrivnas = totalKopecks / 100; return new Money(a.grivnas + b.grivnas + extraGrivnas, totalKopecks % 100);
    }
    public static Money operator -(Money a, Money b)
    {
        int totalKopecksA = a.grivnas * 100 + a.kopecks; int totalKopecksB = b.grivnas * 100 + b.kopecks;
        if (totalKopecksB > totalKopecksA) throw new Exception("Банкрот");
        int totalKopecks = totalKopecksA - totalKopecksB; return new Money(totalKopecks / 100, totalKopecks % 100);
    }
    public static Money operator /(Money a, int b)
    {
        if (b <= 0) throw new Exception("Деление на ноль или отрицательное число");
        int totalKopecks = a.grivnas * 100 + a.kopecks; totalKopecks /= b;
        return new Money(totalKopecks / 100, totalKopecks % 100);
    }
    public static Money operator *(Money a, int b)
    {
        if (b < 0) throw new Exception("Умножение на отрицательное число");
        int totalKopecks = (a.grivnas * 100 + a.kopecks) * b; return new Money(totalKopecks / 100, totalKopecks % 100);
    }
    public static Money operator ++(Money a)
    {
        int totalKopecks = a.grivnas * 100 + a.kopecks + 1; return new Money(totalKopecks / 100, totalKopecks % 100);
    }
    public static Money operator --(Money a)
    {
        int totalKopecks = a.grivnas * 100 + a.kopecks - 1; if (totalKopecks < 0)
            throw new Exception("Банкрот"); return new Money(totalKopecks / 100, totalKopecks % 100);
    }
    public static bool operator <(Money a, Money b)
    {
        return a.grivnas < b.grivnas || (a.grivnas == b.grivnas && a.kopecks < b.kopecks);
    }
    public static bool operator >(Money a, Money b)
    {
        return a.grivnas > b.grivnas || (a.grivnas == b.grivnas && a.kopecks > b.kopecks);
    }
    public static bool operator ==(Money a, Money b)
    {
        return a.grivnas == b.grivnas && a.kopecks == b.kopecks;
    }
    public static bool operator !=(Money a, Money b)
    {
        return a.grivnas != b.grivnas || a.kopecks != b.kopecks;
    }
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType()) return false;
        Money m = (Money)obj; return grivnas == m.grivnas && kopecks == m.kopecks;
    }
    public override int GetHashCode()
    {
        return grivnas * 100 + kopecks;
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Money money1 = new Money(10, 50);
            Money money2 = new Money(5, 25);

            Money sum = money1 + money2;
            Console.WriteLine("Sum result: " + sum.grivnas + " grivnas " + sum.kopecks + " kopecks");

            Money diff = money1 - money2;
            Console.WriteLine("Subtraction result: " + diff.grivnas + " grivnas " + diff.kopecks + " kopecks");

            Money div = money1 / 2;
            Console.WriteLine("Division result: " + div.grivnas + " grivnas " + div.kopecks + " kopecks");

            Money mult = money1 * 2;
            Console.WriteLine("Multiplication result: " + mult.grivnas + " grivnas " + mult.kopecks + " kopecks");

            Money inc = ++money1;
            Console.WriteLine("Increment result: " + inc.grivnas + " grivnas " + inc.kopecks + " kopecks");

            Money dec = --money1;
            Console.WriteLine("Decrement result: " + dec.grivnas + " grivnas " + dec.kopecks + " kopecks");

            Money zeroDiv = money1 / 0;
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}
