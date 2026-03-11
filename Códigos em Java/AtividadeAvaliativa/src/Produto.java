
public class Produto {
	
	private int id;
	private String descricao;
	private double preco;
	private int quantidade;
	
	public Produto() {
	}
	public Produto(int id, String descricao, double preco, int quantidade) {
		this.id = id;
		this.descricao = descricao;
		this.preco = preco;
		this.quantidade = quantidade;
	}
	public void setQuantidade(int quantidade) {
		if (quantidade<0) {
			this.quantidade = 0;}
		else {
			this.quantidade = quantidade;}
		}
	public int getQuantidade() {
		return this.quantidade;
	}
	public void setId(int id) {
		this.id = id;
	}
	public int getId() {
		return this.id;
	}
	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
	public String getDescricao() {
		return this.descricao;
	}
	public void setPreco(double preco) {
		this.preco = preco;
	}
	public double getPreco() {
		return this.preco;
	}
}
