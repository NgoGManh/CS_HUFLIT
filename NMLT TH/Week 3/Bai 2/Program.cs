using System;

namespace Week_3 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Write("Nhập n = ");
			int n = int.Parse(Console.ReadLine());
			string s = "";
			for (int i = 1; i <= n; i++) {
				if (n % i == 0) {
					Console.Write(i + " ");
				}
			}
		}
	}
}
