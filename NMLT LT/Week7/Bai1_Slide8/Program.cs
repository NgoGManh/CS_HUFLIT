using System;

namespace Bai1 {
	class Program {
		static bool[] XacDinhGiaTri(int[] a) {
			int max = a[0];
			for (int i = 1; i < a.Length; i++) {
				if (a[i] > max) {
					max = a[i];
					Console.WriteLine("max = " + max);
				}
			}
			bool[] states = new bool[max + 1];
			for (int i = 0; i < a.Length; i++) {
				Console.WriteLine($"states[a{i}] = {states[a[i]]} trước khi đánh dấu = " + states[a[i]]);
				if (states[a[i]] == false) {
					states[a[i]] = true;
					Console.WriteLine($"states[a{i}] = {states[a[i]]} sau khi đánh dấu = " + states[a[i]]);
				}
			}
			return states;
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			for (int i = 0; i < n; i++) {
				Console.WriteLine($"Nhập a[{i}] : ");
				a[i] = int.Parse(Console.ReadLine());
			}
			int sum = 0;
			bool[] trangthai = XacDinhGiaTri(a);
			for (int i = 1; i < trangthai.Length; i++) {
				if (trangthai[i] == true) {
					sum += 1;
				}
			}
			Console.WriteLine("Số phần tử có giá trị phân biệt là: " + sum);
		}
	}
}
