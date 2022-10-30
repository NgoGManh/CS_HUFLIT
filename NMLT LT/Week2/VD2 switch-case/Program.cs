internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Salary              Increase Percentual");
        Console.WriteLine("0 - 400.00          15%");
        Console.WriteLine("400.01 - 800.00     12%");
        Console.WriteLine("800.01 - 1200.00    10%");
        Console.WriteLine("1200.01 - 2000.00   7%");
        Console.WriteLine("Acima de 2.000      4%");
        Console.WriteLine("Hay nhap luong hien tai cua nhan vien.");
        double curentslr = int.Parse(Console.ReadLine());
        double newslr;
        switch (curentslr)
        {
            case <= 400.00:
                newslr = Math.Round(curentslr * 1.15);
                Console.WriteLine("Luong moi = " + newslr);
                break;
            case <= 800.00:
                newslr = Math.Round(curentslr * 1.12);
                Console.WriteLine("Luong moi = " + newslr);
                break;
            case <= 1200.00:
                newslr = Math.Round(curentslr * 1.10);
                Console.WriteLine("Luong moi = " + newslr);
                break;
            case <= 2000.00:
                newslr = Math.Round(curentslr * 1.07);
                Console.WriteLine("Luong moi = " + newslr);
                break;
            case > 2000.00:
                newslr = Math.Round(curentslr * 1.04);
                Console.WriteLine("Luong moi = " + newslr);
                break;
        }
    }
}