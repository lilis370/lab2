using System;
namespace lab2
{
	class lab2 
	{
		static void Main(string[] args)
		{
			int a=0;
			int b=0;
		
			Console.WriteLine("pilih menu Calculator\n");
			Console.WriteLine("1. Penambahan\n");
			Console.WriteLine("2. Pengurangan\n");
			Console.WriteLine("3. Perkalian\n");
			Console.WriteLine("4. Pembagian\n");
		
			Console.WriteLine("inputkan nomor menu(1...4) :");
			int pilihan = int.Parse(Console.ReadLine());
				if(pilihan == 1){
				
					Console.WriteLine("inputkan nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("inputkan nilai b = ");
					b=int.Parse(Console.ReadLine());
				Console.WriteLine("Hasil Penambahan: {0}+(1}={2)}", a, b, penambahan(a, b) );
				}
				else if(pilihan == 2){
					Console.WriteLine("inputkan nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("inputkan nilai b = ");
					b=int.Parse(Console.ReadLine());
				Console.WriteLine("Hasil Pengurangan: {0}-{1}={2}", a, b, pengurangan(a, b) );
				}
				else if(pilihan == 3){
					Console.WriteLine("inputkan nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("inputkan nilai b = ");
					b=int.Parse(Console.ReadLine());
					Console.WriteLine("Hasil Perkalian: {0}*{1}={2}", a, b, perkalian(a, b) );
				}
				else if(pilihan == 4){
					Console.WriteLine("inputkan nilai a = ");
					a=int.Parse(Console.ReadLine());
					Console.WriteLine("inputkan nilai b = ");
					b=int.Parse(Console.ReadLine());
					Console.WriteLine("Hasil Pembagian: {0}/{1}={2}", a, b, pembagian(a, b) );
				}
				else{
					Console.WriteLine("Maaf, menu yang anda pilih tidak tersedia");
				}
			
		Console.WriteLine("\nTekan sembarang key untuk keluar");			
		Console.ReadKey();			
		}
		static int penambahan(int a, int b)
		{
			return a + b;
		}
		static int pengurangan(int a, int b)
		{
			return a - b;
		}
		static int perkalian(int a, int b)
		{
			return a * b;
		}
		static int pembagian(int a, int b)
		{
			return a / b;
		}
	}
}	