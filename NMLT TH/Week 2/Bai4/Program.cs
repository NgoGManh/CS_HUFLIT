using System;

namespace Bai4 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Hãy nhập a, b và c.");
			double a, b, c;
			double x = 0;
			a = double.Parse(Console.ReadLine());
			b = double.Parse(Console.ReadLine());
			c = double.Parse(Console.ReadLine());
			if (a > b && a > c) {
				Console.Write($"{a}, ");
			} else if{
				Console.WriteLine($"a = {a} là số lớn nhất.");
			} else if (b > c && b > a) {
				Console.WriteLine($"b = {b} là số lớn nhất.");
			} else if (a == b && b == c) {
				Console.WriteLine($"Cả a, b và c bằng nhau.");
			} else {
				Console.WriteLine($"c = {c} là số lớn nhất.");
			}

		}
	}
}
