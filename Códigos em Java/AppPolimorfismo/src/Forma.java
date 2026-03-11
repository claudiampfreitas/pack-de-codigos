public class Forma {

	public void desenhar() {
		// A substituir pela implementação oficial...
		System.out.println("Forma");
	}
}

class Circulo extends Forma {
	@Override
	public void desenhar() {
		System.out.println("Círculo");
	}
}

class Quadrado extends Forma {
	/* ... */ }

class Triangulo extends Forma {
	/* ... */ }
