import java.awt.JobAttributes;
import java.util.SortedMap;

import javax.swing.JOptionPane;

public class Principal {

	public static void main(String[] args) {
		// pedi os valores
		String num1 = JOptionPane.showInputDialog(null, "Digite um numero");
		String num2 = JOptionPane.showInputDialog(null, "Digite um numero");
		String num3 = JOptionPane.showInputDialog(null, "Digite um numero");
		// converti os valores
		double n1 = Double.parseDouble(num1);
		double n2 = Double.parseDouble(num2);
		double n3 = Double.parseDouble(num3);
		informacoes(n1, n2, n3);
	}

	public static double soma(double n1, double n2, double n3) {

		return n1 + n2 + n3;

	}

	public static double media(double n1, double n2, double n3) {
		return soma(n1, n2, n3) / 3;
	}

	public static void informacoes(double n1, double n2, double n3) {
		JOptionPane.showMessageDialog(null, "A soma e: " + soma(n1, n2, n3));
		JOptionPane.showMessageDialog(null, "A media e: " + media(n1, n2, n3));
	}

}