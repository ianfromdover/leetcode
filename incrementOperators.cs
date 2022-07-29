public class IncrementOperators
{
    public static int x = 0;

    public static void Main()
    {
        Console.WriteLine("0. Start at 0");
        Console.WriteLine("1. Do ++x");
        Console.WriteLine(++x); // incr before displaying value

        Console.WriteLine("2. Do x++");
        Console.WriteLine(x++); // display value first then increment and write to i

        Console.WriteLine("3. Do ++x");
        Console.WriteLine(++x); // incr before displaying value
    }
}
