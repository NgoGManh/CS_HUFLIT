using System;

namespace Test {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			NhapMang(a);
			XuatMang(a);
			Console.WriteLine($"Tổng số chữ số của các phần tử trong mảng là: " + TongSoChuSo(a));
		}
		static void NhapMang(int[] a) {
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"Nhập a[{i}]");
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		static void XuatMang(int[] a) {
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"a[{i}] = {a[i]}");
			}
		}
		static int TongSoChuSo(int[] a) {
			int reminder, sum = 0, x;
			for (int i = 0; i < a.Length; i++) {
				x = a[i];
				reminder = x % 10;
				sum += reminder;
				x = x / 10;
			}
			return sum;
		}
	}
}
