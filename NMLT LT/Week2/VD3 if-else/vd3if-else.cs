/*Viết thuật toán nhập 2 số x, y là tọa độ của một điểm trong mặt phẳng. Hãy cho biết điểm đó thuộc góc phần tư nào, hay điểm đó nằm trên các trục, hay nằm ở gốc tọa độ (x=y=0)*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Vui long nhap gia tri cua x, y tu ban phim!");
        double x, y;
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        if (x > 0 && y > 0)
        {
            Console.WriteLine("x = {0}, y = {1} => Diem thuoc Q1.", x, y);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("x = {0}, y = {1} => Diem thuoc Q2.", x, y);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("x = {0}, y = {1} => Diem thuoc Q3.", x, y);
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("x = {0}, y = {1} => Diem thuoc Q4.", x, y);
        }
        else
        {
            Console.WriteLine("x = {0}, y = {1} => Diem nam giua 2 truc.", x, y);
        }
    }
}