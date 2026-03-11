using System;

namespace pratica03
{
	class Program
	{
		public static void Main(string[] args)
		{
			double Vbase, Altura, Perimetro, Area;
			
			Console.Write("Digite um valor para a base: ");
			Vbase=double.Parse(Console.ReadLine());
			Console.Write("Digite um valor para a altura: ");
			Altura=double.Parse(Console.ReadLine());
			Perimetro=(2*Vbase)+(2*Altura);
			Area=Vbase*Altura;
			Console.WriteLine();
			Console.WriteLine("O perímetro do retângulo é: "+Perimetro);
			Console.WriteLine("A área do retângulo é: "+Area);
			Console.WriteLine();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}