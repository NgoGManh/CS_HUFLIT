internal class Program {
	private static void Main(string[] args) {
		Console.WriteLine("Vui long nhap a, b, c tu ban phim!");
		int a, b, c;
		a = int.Parse(Console.ReadLine());
		b = int.Parse(Console.ReadLine());
		c = int.Parse(Console.ReadLine());
		if (a >= b && a >= c) {
			Console.WriteLine("Vay a = {0} la so lon nhat", a);
		} else if (b >= a && b >= c) {
			Console.WriteLine("Vay b = {0} la so lon nhat", b);
		} else {
			Console.WriteLine("Vay c = {0} la so lon nhat", c);
		}
	}
}