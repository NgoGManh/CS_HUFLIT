using System;

namespace Bai6 {
	class Program {
		static int TinhTongMang(int[] a, int n) {
			int sum = 0;
			for (int i = 0; i < n; i++) {
				sum += a[i];
			}
			return sum;
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < n; i++) {
				Console.WriteLine($"Nhập a[{i}] : ");
				a[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine($"Tổng của mảng gồm {n} phần tử = " + TinhTongMang(a, n));
		}
	}
}
