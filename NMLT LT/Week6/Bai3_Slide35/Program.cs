﻿using System;

namespace Bai3_Slide35 {
	class Program {
		static void NhapMang(int[] a, int n) {
			for (int i = 0; i < n; i++) {
				Console.WriteLine($"Nhập a[{i}] : ");
				a[i] = int.Parse(Console.ReadLine());
			}
		}
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.WriteLine("Nhập số phần tử của mảng.");
			int n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			NhapMang(a, n);
		}
	}
}
