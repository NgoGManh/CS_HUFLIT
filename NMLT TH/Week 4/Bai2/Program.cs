using System;

namespace Bai2 {
	class Program {
		static void HoanDoi(ref int a, ref int b) {
			int temp = a;
			a = b;
			b = temp;
			Console.WriteLine($"Trong hàm hoán đổi : a = {a}, b = {b}");
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập a và b");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine($"Trước Khi Hoán Đổi : a = {a}, b = {b}");
			HoanDoi(ref a, ref b);
			Console.WriteLine($"Sau Khi Hoán Đổi : a = {a}, b = {b}");
			Console.ReadKey();
		}
	}
}
