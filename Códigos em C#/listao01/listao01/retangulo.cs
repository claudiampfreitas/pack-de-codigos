
using System;

namespace listao01
{
	/// <summary>
	/// Description of retangulo.
	/// </summary>
	public class retangulo
	{
		
		private double valtura,area,perimetro, vbase;
		
		public void LerDados()
		{
		
			Console.Write("Digite a base do triangulo: ");
			vbase = double.Parse(Console.ReadLine());
			Console.Write("Digite a altura do triangulo: ");
			valtura = double.Parse(Console.ReadLine());
			
		}
		
		public void CalcularArea()
		{
			area = vbase*valtura;
		}
		
		public void CalcularPerimetro()
		{
			perimetro = valtura + vbase*2;
		}
		
		public void MostrarResultados()
		{
			Console.WriteLine("A area e de " +area+" tem perimetro de " + perimetro);
		}
	}
}
