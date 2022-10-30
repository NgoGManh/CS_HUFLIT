using System;

namespace Bai2 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập n là năm bất kỳ.");
			int n = int.Parse(Console.ReadLine());
			if (n % 4 == 0) {
				Console.WriteLine($"{n} là năm nhuận.");
			} else {
				Console.WriteLine($"{n} là năm không nhuận.");
			}
		}
	}
}


