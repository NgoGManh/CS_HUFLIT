/*Nhập vào code của sản phẩm và số lượng sản phẩm sẽ mua. Sau đó in ra số tiền phải trả dựa trên bảng giá sau:*/
internal class Program {
	private static void Main(string[] args) {
		Console.WriteLine("CODE     SPECIFICATION     PRICE");
		Console.WriteLine("1        Cachorro Quente   R$4.00");
		Console.WriteLine("2        X-Salada          R$4.00");
		Console.WriteLine("3        X-Bacon           R$5.00");
		Console.WriteLine("4        Corrada simples   R$2.00");
		Console.WriteLine("5        Refrigerante      R$1.50");
		Console.WriteLine("Hay nhap code mon hang va so luong can mua!");
		double code = int.Parse(Console.ReadLine());
		double amount = int.Parse(Console.ReadLine());
		switch (code) {
			case 1:
				code = amount * 4.00;
				Console.WriteLine("Tong cong = $" + code);
				break;
			case 2:
				code = amount * 4.50;
				Console.WriteLine("Tong cong = $" + code);
				break;
			case 3:
				code = amount * 5.00;
				Console.WriteLine("Tong cong = $" + code);
				break;
			case 4:
				code = amount * 2.00;
				Console.WriteLine("Tong cong = $" + code);
				break;
			case 5:
				code = amount * 1.50;
				Console.WriteLine("Tong cong = $" + code);
				break;
			default:
				Console.WriteLine("Ma hang khong ton tai!");
				break;
		}
	}
}