using System;

namespace Bai2 {
	class Program {
		public static void Main() {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			int n;
			Console.WriteLine("Nhập n.");
			n = int.Parse(Console.ReadLine());
			bool[] a = new bool[n + 1];
			for (int i = 2; i <= n; i++) {
				a[i] = true;
			}
			for (int i = 2; i < Math.Sqrt(n); i++) {
				if (a[i]) {
					int j = (int)Math.Pow(i, 2);
					while (j <= n) {
						a[j] = false;
						j += i;
					}
				}
			}
			Console.WriteLine("Các số nguyên tố bé hơn n là:");
			for (int i = 2; i <= n; i++) {
				if (a[i]) {
					Console.Write("{0}, ", i);
				}
			}
		}
	}
}
