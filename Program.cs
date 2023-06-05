internal class Program
{
    private static void Main(string[] args)
    {
        var ppa = Formulinha.AnoPertencentePpa(2000);
        Console.WriteLine(ppa);
    }
}

public class Formulinha
{
    public static int AnoPertencentePpa(int anoRef)
    {
        int base_ = 1998;
        int x = (anoRef - base_) / 4;
        int y = base_ + x * 4;

        return y;
    }
}