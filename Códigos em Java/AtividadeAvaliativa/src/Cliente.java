
public class Cliente {

	private int id;
	private String nome;
	private String cpf;
	private Endereco endereco;
	
	public Cliente() {
		
	}
	
	public Cliente(int id, String nome, String cpf, Endereco endereco) {
		this.id = id;
		this.nome = nome;
		this.cpf = cpf;
		this.endereco = endereco;
	}
	
	public void setId(int id) {
		this.id = id;
	}
	public int getId() {
		return this.id;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getNome() {
		return this.nome;
	}
	public void setCpf(String cpf) {
		if (cpf.length() != 11) {
			this.cpf = "0";}
		else {
			this.cpf = cpf;}
	}
	public String getCpf() {
		return this.cpf;
	}
	public void setEndereco(Endereco endereco) {
		this.endereco = endereco;
	}
	public Endereco getEndereco() {
		return this.endereco;
	}
}
