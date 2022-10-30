using System;

namespace BT3_B1 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập a và b từ bàn phím!");
			int a, b;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			Console.WriteLine("a = {0}, b = {1}", a, b);
			Console.WriteLine($"{a} + {b} = " + (a + b));
			Console.WriteLine($"{a} - {b} = " + (a - b));
			Console.WriteLine($"{a} * {b} = " + (a * b));
			Console.WriteLine($"{a} / {b} = " + (a / b));
			Console.WriteLine($"{a} % {b} = " + (a % b));
		}
	}
}
