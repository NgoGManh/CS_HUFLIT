using System;

namespace NMLT_TH {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Vui lòng nhập vào bàn phím một chuỗi số nguyên!");
			string stringNumber = Console.ReadLine();
			Console.WriteLine("\"stringNumber\" value & type: " + stringNumber + ", " + stringNumber.GetType());
			int intNumber = int.Parse(stringNumber);
			Console.Write("\"intNumber\" value & type: " + intNumber + ", " + intNumber.GetType());
		}
	}
}
