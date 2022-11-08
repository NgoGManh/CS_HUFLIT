using System;

namespace Bai8 {
	class Program {
		static int TinhTong(int n) {
			int sotachra;
			int s = 0;
			for (; n != 0;) {
				sotachra = n % 10;
				s += sotachra;
				n /= 10;
			}
			return s;
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập n");
			int n = int.Parse(Console.ReadLine());
			Console.WriteLine("Tổng các chữ số = " + TinhTong(n));
			Console.ReadKey();
		}
	}
}
