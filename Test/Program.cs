using System;

namespace Test {
	class Program {
		static int TimMin(int a, int b, int c) {
			int max = a;
			if (max > b) {
				max = b;
			}

			if (max > c) {
				max = c;
			}
			return max;
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập a, b, c");
			int a, b, c;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());
			Console.Write($"Số bé nhất là: " + TimMin(a, b, c));
		}
	}
}
