using System;

namespace Bai4 {
	class Program {
		static void TimViTri(double[] a, double x) {
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"Nhập a[{i}] ");
				a[i] = double.Parse(Console.ReadLine());
			}

			for (int i = 0; i < a.Length; i++) {
				if (a[i] == x) {
					Console.WriteLine($"Vị trí của phần tử có giá trị x là: a[{i}]");
				}
			}
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			double[] a = new double[n];
			Console.WriteLine($"Nhập x");
			double x = double.Parse(Console.ReadLine());
			TimViTri(a, x);
		}
	}
}
