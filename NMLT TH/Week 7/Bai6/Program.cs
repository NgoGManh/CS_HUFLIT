using System;

namespace Bai6 {
	class Program {
		static void TimViTri(double[] a) {
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"Nhập a[{i}] ");
				a[i] = double.Parse(Console.ReadLine());
			}
			double min = a[0];
			for (int i = 0; i < a.Length; i++) {
				if (a[i] < min) {
					min = a[i];
				}
			}
			for (int i = 0; i < a.Length; i++) {
				if (a[i] == min) {
					Console.WriteLine($"Vị trí của giá trị nhỏ nhất trong mảng là: a[{i}]");
				}
			}
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			double[] a = new double[n];
			TimViTri(a);
		}
	}
}
