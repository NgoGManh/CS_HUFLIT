using System;

namespace Bai2 {
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
		static int DemSoChuSo(int x) {
			int count = 0;
			if (x == 0) {
				count++;
			}
			while (x != 0) {
				x = x / 10;
				count++;
			}
			return count;
		}
		static int TongSoChuSo(int[] a) {
			int sum = 0;
			for (int i = 0; i < a.Length; i++) {
				int x = a[i];
				DemSoChuSo(x);
				sum += DemSoChuSo(x);
			}
			return sum;
		}
	}
}
