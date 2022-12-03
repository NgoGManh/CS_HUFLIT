using System;

namespace Bai4 {
	class Program {
		static void Main(string[] args) {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			int[] arr1 = new int[100];
			int[] fr1 = new int[100];
			int n, i, j, bien_dem;

			Console.Write("Nhập số phần tử cần lưu giữ trong mảng: ");
			n = int.Parse(Console.ReadLine());

			Console.Write("Nhập {0} phần tử trong mảng:\n", n);
			for (i = 0; i < n; i++) {
				Console.Write("Phần tử - {0}: ", i);
				arr1[i] = int.Parse(Console.ReadLine());
				fr1[i] = -1;
			}
			for (i = 0; i < n; i++) {
				bien_dem = 1;
				for (j = i + 1; j < n; j++) {
					if (arr1[i] == arr1[j]) {
						bien_dem++;
						fr1[j] = 0;
					}
				}

				if (fr1[i] != 0) {
					fr1[i] = bien_dem;
				}
			}
			Console.Write("\nTần suất xuất hiện của từng phần tử trong mảng là: \n");
			for (i = 0; i < n; i++) {
				if (fr1[i] != 0) {
					Console.Write("Phần tử {0} xuất hiện {1} lần\n", arr1[i], fr1[i]);
				}
			}

			Console.ReadKey();
		}
	}
}
