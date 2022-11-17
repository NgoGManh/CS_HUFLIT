using System;

namespace Test {
	class Program {
		static void TimMinMax(int a, int b, int c, out int max, out int min) {
			min = a;
			if (min > b) {
				min = b;
			}
			if (min > c) {
				min = c;
			}
			max = a;
			if (max < b) {
				max = b;
			}
			if (max < c) {
				max = c;
			}
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập a, b, c");
			int a, b, c;
			a = int.Parse(Console.ReadLine());
			b = int.Parse(Console.ReadLine());
			c = int.Parse(Console.ReadLine());
			int max, min;
			TimMinMax(a, b, c, out max, out min);
			Console.WriteLine($"Số lớn nhất trong 3 số {a}, {b}, {c} là: " + max);
			Console.WriteLine($"Số bé nhất trong 3 số {a}, {b}, {c} là: " + min);
			Console.ReadKey();
		}

	}
}
