using System;

namespace Bai5 {
	class Program {
		static void TimMax(int[] a) {
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"Nhập a[{i}] ");
				a[i] = int.Parse(Console.ReadLine());
			}
			int max = a[0];
			for (int i = 0; i < a.Length; i++) {
				if (a[i] > max) {
					max = a[i];
				}
			}
			Console.WriteLine($"Giá trị lớn nhất trong mảng là {max}");
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			TimMax(a);
		}
	}
}
