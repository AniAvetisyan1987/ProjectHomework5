using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(myFunction(123));
        Console.WriteLine(myFunction(623));
        Console.WriteLine(myFunction(12));
        Console.WriteLine(myFunction(523));
        Console.ReadKey();
    }

    // ex:51
    static bool myFunction(int num)
    {
        string number = num.ToString();
        if (num / 100 > 0)
        {
            if (Char.GetNumericValue(number[2]) ==
                (Char.GetNumericValue(number[0]) + Char.GetNumericValue(number[1])))
            {
                return true;
            }
            return false;
        }
        return false;
    }
}