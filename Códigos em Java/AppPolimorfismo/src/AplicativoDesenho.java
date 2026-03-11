public class AplicativoDesenho {

	private static void desenhar(Forma[] fs) {
		for (int i = 0; i < fs.length; i++)
			fs[i].desenhar();
	}

	public static void main(String[] args) {
		Forma[] formas = new Forma[] {
		new Circulo(), new Forma(),
		new Quadrado(), new Triangulo()
		};
		desenhar(formas);
		}
}
