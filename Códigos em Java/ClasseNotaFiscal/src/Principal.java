public class Principal {

	public static void main(String[] args) {
		Cliente c = new Cliente("Cláudia", "12345");
		Fornecedor f = new Fornecedor("Alto Grado", "1122334455");
		Mercadoria m = new Mercadoria("Calças jeans", 70.00);
		
	double valortotal = 0;
	NotaFiscal nf = new NotaFiscal(c, f, m, valortotal);
	nf.ExibirInfo(c, f, m, valortotal);
	}

}