using System;

namespace Bai7 {
	class Program {
		static void TimSoLanXuatHien(int[] a) {
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"Nhập a[{i}] ");
				a[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine($"Nhập x ");
			int x = int.Parse(Console.ReadLine());
			int sum = 0;
			for (int i = 0; i < a.Length; i++) {
				if (x == a[i]) {
					sum += 1;
				}
			}
			Console.WriteLine($"x = {x} xuất hiện {sum} lần trong mảng.");
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			TimSoLanXuatHien(a);
		}
	}
}