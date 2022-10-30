using System;

namespace BT5_B1 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập n ");
			int n = int.Parse(Console.ReadLine());
			int x = 1;
			int sum = 0;
			while (x <= n) {
				Console.WriteLine("Nhập a" + x);
				int a = int.Parse(Console.ReadLine());
				sum = sum + a;
				x++;
			}
			Console.Write(sum);
		}
	}
}
