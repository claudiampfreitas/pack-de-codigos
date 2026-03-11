
using System;

namespace listao01
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			retangulo r1 = new retangulo();
			r1.LerDados();
			r1.CalcularArea();
			r1.CalcularPerimetro();
			r1.MostrarResultados();
			Console.ReadKey();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}