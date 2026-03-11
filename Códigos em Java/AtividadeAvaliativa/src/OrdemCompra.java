
public class OrdemCompra {
	
	private Produto produto;
	private Cliente cliente;
	
	public OrdemCompra() {
		
	}
	
	public OrdemCompra(Produto produto, Cliente cliente) {
		this.produto = produto;
		this.cliente = cliente;
	}
	
	public void setProduto(Produto produto) {
		this.produto = produto;
	}
	public Produto getProduto() {
		return this.produto;
	}
	public void setCliente(Cliente cliente) {
		this.cliente = cliente;
	}
	public Cliente getCliente() {
		return this.cliente;
	}
	
	public void ExibirInformacoes() {
		System.out.println();
		System.out.println("ID do cliente: " +this.cliente.getId());
		System.out.println("Nome do cliente: " +this.cliente.getNome());
		System.out.println("CPF do cliente: " +this.cliente.getCpf());
		System.out.println("Logradouro do cliente: " +this.cliente.getEndereco().getLogradouro());
		System.out.println("Número da rua: " +this.cliente.getEndereco().getNumero());
		System.out.println("Bairro do cliente: " +this.cliente.getEndereco().getBairro());
		System.out.println("Cidade do cliente: " +this.cliente.getEndereco().getCidade());
		System.out.println("Estado em que reside: " +this.cliente.getEndereco().getEstado());
		System.out.println("ID do produto: " +this.produto.getId());
		System.out.println("Descrição do produto: " +this.produto.getDescricao());
		System.out.println("Preço do produto: " +this.produto.getPreco());
		System.out.println("Quantidade comprada: " +this.produto.getQuantidade());
	}
}
