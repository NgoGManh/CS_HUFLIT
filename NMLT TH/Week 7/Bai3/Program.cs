using System;

namespace Bai3 {
	class Program {
		static void TongMang(int[] a) {
			int sum = 0;
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"Nhập a[{i}] ");
				a[i] = int.Parse(Console.ReadLine());
				sum += a[i];
			}
			Console.WriteLine($"Tổng các phần tử = {sum}");
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			TongMang(a);
		}
	}
}
