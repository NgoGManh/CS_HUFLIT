using System;

namespace Bai6 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Write("Nhập n = ");
			int n = int.Parse(Console.ReadLine());
			bool IsPrime = true;
			//n < 2 vi n = 0, 1 thi khong la so nguyen to.
			if (n < 2) {
				IsPrime = false;
			}
			for (int i = 2; i < n / 2; i++) {
				if (n % i == 0) {
					IsPrime = false;
					break;
				}
			}
			if (IsPrime) {
				Console.Write($"{n} là số nguyên tố.");
			} else {
				Console.Write($"{n} không phải là số nguyên tố.");
			}
			Console.ReadKey();
		}
	}
}
