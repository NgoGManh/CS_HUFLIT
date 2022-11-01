using System;

namespace Bai14 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			int n;
			do {
				Console.Write("Nhap 1 <= n <= 1000: ");
				n = int.Parse(Console.ReadLine());
			}
			while (n < 1 || n > 1000);

			int qua = 0;
			int s = n;

			do {
				qua = (s / 10) * 3 + qua;
				s = s % 10 + qua;
			}
			while (s >= 10);
			Console.WriteLine($"Tổng số chai uống là : {qua}, {n}");
		}
	}
}
