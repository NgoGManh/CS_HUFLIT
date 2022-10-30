/*Cho số thực x. Hãy cho biết x thuộc đoạn nào sau đây: 
[0,25], (25,50], (50,75], (75,100]*/

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vui long nhap gia tri cua x tu ban phim!");
        int x = int.Parse(Console.ReadLine());
        if (x >= 0 && x <= 25)
        {
            Console.WriteLine("x thuoc [0,25]");
        }
        if (x > 25 && x <= 50)
        {
            Console.WriteLine("x thuoc (25,50]");
        }
        if (x > 50 && x <= 75)
        {
            Console.WriteLine("x thuoc (50,75]");
        }
        if (x > 75 && x <= 50)
        {
            Console.WriteLine("x thuoc (75,100]");
        }
    }
}