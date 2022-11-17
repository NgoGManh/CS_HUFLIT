using System;

namespace Bai4 {
	class Program {
		static void TaoMang() {
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < n; i++) {
				Console.WriteLine($"Nhập a[{i}] : ");
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			TaoMang();
		}
	}
}
