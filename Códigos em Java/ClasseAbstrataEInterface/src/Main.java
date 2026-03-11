public class Main {

	public static void main(String[] args) {
		
		Secretaria s = new Secretaria(1, "Márcia", "98888-8888", 2000.00, "Secretária", 500.00);
		
		Operador o = new Operador(2, "Alexandre", "97575-7575", 1500.00, "Operador", 200.00);
		
		Auxiliar a = new Auxiliar(3, "Severino", "98484-8484", 1300.00, "Auxiliar");
		
		Gerente g = new Gerente(4, "Mário", "98686-8686", 5000.00, "Gerente");
		
		System.out.println(s.toString());
		System.out.println(o.toString());
		System.out.println(a.toString());
		System.out.println(g.toString());

	}
}
