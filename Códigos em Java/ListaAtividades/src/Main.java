import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Atividade 1");
        System.out.println();
        for (int num = 0; num < 101; num += 3) {
            System.out.println("Números entre 0 e 100: " + num);
        }
        System.out.println();
        System.out.println("Atividade 2");
        int cont = 1;
        while (cont <= 10) {
            if ((cont % 4 == 0)) {
                System.out.println(cont);
            }
            cont++;
        }
        System.out.println();
        System.out.println("Atividade 3");
        int resp = 1;
        do {
            System.out.println("Digite um nome: ");
            String nome = sc.nextLine();
            System.out.println("Digite um CPF: ");
            String CPF = sc.nextLine();
            System.out.println("Digite um endereço: ");
            String endereco = sc.nextLine();
            System.out.println("Deseja continuar? (Digite 1 para sim ou 2 para não): ");
            resp = sc.nextInt();
            sc.nextLine();
        } while (resp != 2);
        System.out.println();
        System.out.println("Atividade 4");
		String meses[] = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro",
				"Outubro", "Novembro", "Dezembro" };
		int dias[] = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		for (int i = 0; i < 12; i++) {
			System.out.println(meses[i] + " - " + dias[i]);
		}
		System.out.println();
		System.out.println("Atividade 5");
		int numeros[] = new int[20];

		for (int i = 0; i <= 19; i++) {
			if (i % 2 == 0) {
				numeros[i] = i + i;
			} else
				numeros[i] = i + i;
		}
		for (int i = 0; i <= 19; i++) {
			System.out.println("Pares[" + (i + 1) + "]=" + numeros[i]);
		}
		System.out.println();
		System.out.println("Atividade 6");
		int vet[] = new int[10];

		for (int i = 0; i <= 9; i++) {
			vet[i] = (i * 2) - 3;
		}
		for (int i = 0; i <= 9; i++) {
			System.out.println("Vetor[" + i + "]=" + vet[i]);
		}
		System.out.println();
		System.out.println("Atividade 7");
		double preco[] = new double[10];
		double soma = 0;

		for (int i = 0; i < preco.length; i++) {
			System.out.println("Qual o preço do produto? ");
			preco[i] = sc.nextDouble();
			soma += preco[i];
		}
		System.out.println("A soma é: " + soma);
		double media = soma / preco.length;
		System.out.println("A média é: " + media);
	}
}
