using System;

class Program
{
    public T Min<T>(T val1, T val2) where T: IComparable<T>
    {
        return val1.CompareTo(val2) < 0 ? val1 : val2;
    }

    public T Max<T>(T val1, T val2) where T: IComparable<T>
    {
        return val1.CompareTo(val2) > 0 ? val1 : val2;
    }

    static void Main(string[] args)
    {
        Program program = new Program();

        int result1 = program.Min(5,10);
        Console.WriteLine("Minsta värde är: " + result1 );

        double result2 = program.Min(3.5, 1.2);
        Console.WriteLine("Minsta värde är: " + result2);

        int result3 = program.Max(10, 100);
        Console.WriteLine("Max värde är: " + result3);

        double result4 = program.Min(2, 2);
        Console.WriteLine("Minsta värde är: " + result4);
    }
}