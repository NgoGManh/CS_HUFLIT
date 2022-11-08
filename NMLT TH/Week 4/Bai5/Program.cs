using System;

namespace Bai5 {
	class Program {
		static int TimMax(int a, int b, int c) {
			int max = a;
			if (max < b) {
				max = b;
			}
			if (max < c) {
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
			Console.WriteLine($"Số lớn nhất trong 3 số {a}, {b}, {c} là: " + TimMax(a, b, c));
			Console.ReadKey();
		}
	}
}