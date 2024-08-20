namespace enums;

public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter
}

public class EnumConversionExample
{
    public static void MainSeasons()
    {
        Season a = Season.Autumn;
        Console.WriteLine($"Integral value of {a} is {(int)a}");
        Console.ReadLine();

        var b = (Season)1;
        Console.WriteLine(b);
        Console.ReadLine();

        var c = (Season)4;
        Console.WriteLine(c);
        Console.ReadLine();
    }
}