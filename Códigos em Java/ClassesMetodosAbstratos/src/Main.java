public class Main {

	public static void main(String[] args) {
		Operador o = new Operador(1, "Alexandre", "98888-8888", 1200, "Operador", getAdicional_noturno());
		o.toString();
		o.getAdicional_noturno();
		o.CalcularBonificacao();
		
		Secretaria s = new Secretaria(2, "Beatriz", "97777-7777", 1700, "Secretária", getAdicional_especial());
		s.toString();
		s.getAdicional_especial();
		s.CalcularBonificacao();
		
		Gerente g = new Gerente(3, "Carlos Alberto", "96666-6666", 5000, "Gerente", getAdicional());
		g.toString();
		g.getAdicional();
		g.CalcularBonificacao();
		
		System.out.println(o);
		System.out.println(s);
		System.out.println(g);
	}

	private static double getAdicional() {
		return 0;
	}

	private static double getAdicional_noturno() {
		return 0;
	}

	private static double getAdicional_especial() {
		return 0;
	}
}
