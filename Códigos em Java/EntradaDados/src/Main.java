import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
	//Para a entrada de dados é necessário a instância da classe Scanner
		Scanner sc = new Scanner(System.in);
		System.out.println("Digite um nome: ");
		String nome = sc.nextLine();
		System.out.println("Digite uma nota: ");
		double nota1 = sc.nextDouble();
		System.out.println("Digite outra nota: ");
		double nota2 = sc.nextDouble();
		System.out.println("Digite outra nota: ");
		double nota3 = sc.nextDouble();
		double soma = nota1 + nota2 + nota3;
		double media = (nota1+nota2+nota3)/3;
		System.out.println("O resultado da soma é: " +soma);
		System.out.println("O resultado da média é: " +media);
	}

}