using System;

namespace RaioCirculo
{
	class Program
	{
		public static void Main(string[] args)
		{
			double AreaCirculo=0;
			double RaioDoCirculo=0;
			
			Console.Write("Informe o raio do círculo: ");
			RaioDoCirculo=Convert.ToDouble(Console.ReadLine());
			AreaCirculo=Math.PI*Math.Pow(RaioDoCirculo,2);
			Console.WriteLine();
			Console.WriteLine("A área do círculo de raio " + RaioDoCirculo.ToString() + " é: " + AreaCirculo.ToString());
			
			Console.ReadKey();
		}
	}
}