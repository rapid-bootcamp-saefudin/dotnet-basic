using LinqTutorial;
using LinqTutorial.Model;

public class ProgramMain
{
    #region Introduction
    public static void IntroductionLinq()
    {
        Console.Write("Without Linq : ");
        IntroLinq.Introduction();
        Console.Write("\n\nWith Linq : ");
        IntroLinq.IntroductionWithLinq();
    }
    #endregion

    public static void Main()
    {
        Product.SampleFilterProductByName();
    }
}