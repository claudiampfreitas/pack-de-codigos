using System;

namespace ExerciciosAnaliseSistemas
{
	class Program
	{
		static int gcd(int a, int b)
		{
			if (b == 0)
				return a;
			else
				return gcd(b, a % b);
		}
		
		public static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Escolha uma opção:");
				Console.WriteLine("1 - Divisores");
				Console.WriteLine("2 - Máximo divisor comum");
				Console.WriteLine("3 - Média do aluno");
				Console.WriteLine("4 - Notas da classe");

				int opcao = int.Parse(Console.ReadLine());
				Console.WriteLine();

				switch (opcao)
				{
					case 1:
						Console.Write("Digite um número inteiro positivo: ");
						int num = int.Parse(Console.ReadLine());

						if (num == 0)
						{
							throw new ArgumentException("Não existe divisor de zero");
						}
						if (num < 0)
						{
							throw new ArgumentException("O número digitado deve ser positivo!");
						}

						Console.Write("Os divisores de " + num + " são: ");
						for (int i = 1; i <= num; i++)
						{
							if (num % i == 0)
							{
								Console.Write(i + " ");
							}
						}
						break;

					case 2:
						{
							Console.Write("Digite o primeiro número inteiro positivo: ");
							int num1 = int.Parse(Console.ReadLine());

							if (num1 < 0)
							{
								throw new ArgumentException("O primeiro número digitado deve ser positivo!");
							}

							Console.Write("Digite o segundo número inteiro positivo: ");
							int num2 = int.Parse(Console.ReadLine());

							if (num2 < 0)
							{
								throw new ArgumentException("O segundo número digitado deve ser positivo!");
							}

							int mdc = gcd(num1, num2);

							Console.WriteLine("O máximo divisor comum entre " + num1 + " e " + num2 + " é: " + mdc);
							break;
						}

					case 3:
						{
							Console.Write("Digite a primeira nota: ");
							double nota1 = double.Parse(Console.ReadLine());

							Console.Write("Digite a segunda nota: ");
							double nota2 = double.Parse(Console.ReadLine());

							Console.Write("Digite a terceira nota: ");
							double nota3 = double.Parse(Console.ReadLine());

							Console.Write("Digite a quarta nota: ");
							double nota4 = double.Parse(Console.ReadLine());

							double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

							if (media >= 7.0)
							{
								Console.WriteLine("Parabéns, você foi aprovado(a) com média " + media.ToString("F1") + ".");
							}
							else if (media >= 5.0 && media < 7.0)
							{
								Console.WriteLine("Você está em final com média " + media.ToString("F1") + ".");
							}
							else
							{
								Console.WriteLine("Infelizmente, você foi reprovado(a) com média " + media.ToString("F1") + ".");
							}
							break;
						}
						
					case 4:
						{
							int numAlunos = 0;
							int aprovados = 0;
							int reprovados = 0;
							int recuperacao = 0;
							
							Console.Write("Digite o número de alunos a serem avaliados (entre 15 e 35): ");
							numAlunos = int.Parse(Console.ReadLine());
							
							while (numAlunos < 15 || numAlunos > 35) {
								Console.WriteLine("Número de alunos inválido. Digite novamente.");
								Console.Write("Digite o número de alunos a serem avaliados (entre 15 e 35): ");
								numAlunos = int.Parse(Console.ReadLine());
							}
							
							Console.WriteLine();
							for (int i = 1; i <= numAlunos; i++) {
								Console.Write("Digite a nota final do aluno {0}: ", i);
								int nota = int.Parse(Console.ReadLine());
								
								if (nota >= 70) {
									aprovados++;
								} else if (nota >= 60) {
									recuperacao++;
								} else {
									reprovados++;
								}
							}
							
							Console.WriteLine();
							Console.WriteLine("Quantos alunos aprovados? " +aprovados);
							Console.WriteLine("Quantos alunos em recuperação? " +recuperacao);
							Console.WriteLine("Quantos alunos reprovados? " +reprovados);
						}
						break;
						
					default:
						{
							Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
							Console.WriteLine("As opções disponíveis são: 1, 2, 3, 4.");
						}
						break;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadKey();
		}
	}
}