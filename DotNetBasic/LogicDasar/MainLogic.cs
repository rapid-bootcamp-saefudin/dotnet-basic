using LogicDasar;

public class MainLogic
{
    public static void Main()
    {
        Console.Write("Masukan Angka : ");
        string? input = Console.ReadLine();
        Console.WriteLine();
        int n = input == null ? 0 : int.Parse(input);

        Logic02Soal01.CetakNilai(n);
    }
}
