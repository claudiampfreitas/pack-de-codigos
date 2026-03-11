import java.util.Scanner;

public class NotaFiscal {

	Cliente cliente;
	Fornecedor fornecedor;
	Mercadoria mercadoria;
	double valortotal;
	int quantidade;

	public NotaFiscal(Cliente c, Fornecedor f, Mercadoria m, double valortotal) {
		this.cliente = c;
		this.fornecedor = f;
		this.mercadoria = m;
		Scanner sc = new Scanner(System.in);
		System.out.print("Qual a quantidade de produtos comprada? ");
		quantidade = sc.nextInt();
		this.quantidade = quantidade;
		System.out.println();
		valortotal=this.quantidade*this.mercadoria.preco;
		this.valortotal = valortotal;
	}
	public void ExibirInfo(Cliente c, Fornecedor f, Mercadoria m, double valortotal) {
		System.out.println("Nome do cliente: " +this.cliente.nome);
		System.out.println("CPF do cliente: " +this.cliente.cpf);
		System.out.println("Razão social da empresa: " +this.fornecedor.razao_social);
		System.out.println("CNPJ da empresa: " +this.fornecedor.cnpj);
		System.out.println("Descrição do produto: " +this.mercadoria.descricao);
		System.out.println("Preço do produto: " +this.mercadoria.preco);
		System.out.println("Valor total: " +this.valortotal);
	}
}