using System;

namespace Bai3 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			int n;
			Console.WriteLine("Nhập n.");
			n = int.Parse(Console.ReadLine());
			bool[] sum = new bool[n + 1];
			for (int i = 1; i <= n; i++) {
				sum[i] = false;
			}
			Console.WriteLine("Hello World!");
		}
	}
}
