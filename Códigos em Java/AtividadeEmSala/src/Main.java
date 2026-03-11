public class Main {

	public static void main(String[] args) {
		double n1 = 2.0;
		double n2 = 4.0;
		
		System.out.println("A soma é: " +Matematica.soma(n1, n2));
		System.out.println("A subtração é: " +Matematica.subtracao(n1, n2));
		System.out.println("A multiplicação é: " +Matematica.multiplicacao(n1, n2));
		System.out.println("A divisão é: " +Matematica.divisao(n1, n2));
		System.out.println("O mínimo de "+n1+" e "+n2+" é: " +Matematica.minimo(n1, n2));
		System.out.println("O máximo de "+n1+" e "+n2+" é: " +Matematica.maximo(n1, n2));

	}

}