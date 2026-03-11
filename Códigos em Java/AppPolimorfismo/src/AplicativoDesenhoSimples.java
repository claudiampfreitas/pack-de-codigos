public class AplicativoDesenhoSimples {

	public static void desenhar(Forma f) {
		f.desenhar();
	}

	public static void main(String[] args) {
		Circulo c = new Circulo();
		desenhar(c); // Upcasting!
		Forma f = new Quadrado(); // Upcasting!
	}
}
