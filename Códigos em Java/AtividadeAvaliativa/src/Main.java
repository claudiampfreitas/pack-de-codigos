import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		System.out.print("Qual a identificação do cliente? ");
		int idcliente = sc.nextInt();
		System.out.print("Qual o nome do cliente? ");
		String nome = sc.nextLine();
		sc.next();
		System.out.print("CPF do cliente: ");
		String cpf = sc.nextLine();
		System.out.print("Qual o logradouro do cliente? ");
		String logradouro = sc.nextLine();
		System.out.print("Qual o número do logradouro? ");
		int numero = sc.nextInt();
		System.out.print("Qual o bairro do cliente? ");
		String bairro = sc.nextLine();
		
		System.out.print("Qual a cidade do cliente? ");
		String cidade = sc.nextLine();
	
		System.out.print("Qual o estado em que ele reside? ");
		String estado = sc.next();
		System.out.print("Qual a ID do produto? ");
		int idproduto = sc.nextInt();
		System.out.print("Qual o produto comprado? ");
		String compra = sc.nextLine();
		
		System.out.print("Qual a quantidade comprada? ");
		
		int quant = sc.nextInt();
		System.out.print("Qual o preço do produto? ");
		double precoprod = sc.nextDouble();
		
		Produto p = new Produto();
		
		p.setId(idproduto);
		p.setDescricao(compra);
		p.setPreco(precoprod);
		p.setQuantidade(quant);
		
		Endereco e = new Endereco();
		
		e.setLogradouro(logradouro);
		e.setNumero(numero);
		e.setBairro(bairro);
		e.setCidade(cidade);
		e.setEstado(estado);
		
		Cliente c = new Cliente();
		
		c.setId(idcliente);
		c.setNome(nome);
		c.setCpf(cpf);
		c.setEndereco(e);
		
		OrdemCompra oc = new OrdemCompra();
		oc.setCliente(c);
		oc.setProduto(p);
		
		oc.ExibirInformacoes();

	}
}
