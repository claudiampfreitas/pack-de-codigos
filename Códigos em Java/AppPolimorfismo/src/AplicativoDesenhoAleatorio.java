public class AplicativoDesenhoAleatorio {

	public static void main(String[] args) {
		Forma f = null;
		switch ((int) (Math.random() * 3)) {
		case 0:
			f = new Circulo();
			break;
		case 1:
			f = new Quadrado();
			break;
		case 2:
			f = new Triangulo();
			break;
		default:
			f = new Forma();
		}
		f.desenhar();
	}
}