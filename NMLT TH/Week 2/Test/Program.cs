using System;

namespace Test {
	class Program {
		static void Main(string[] args) {
			double a = 1, b = 1, sum = 1;
			for (int i = 0; i < 20; i++) {
				a += +2;
				b *= 2;
				sum += (a / b);
			}
			Console.Write("S = " + sum);
		}
	}
}
