
public class Endereco {
	
	private String logradouro;
	private int numero;
	private String bairro;
	private String cidade;
	private String estado;
	
	public Endereco() {
		
	}
	
	public Endereco(String logradouro, int numero, String bairro, String cidade, String estado) {
		this.logradouro = logradouro;
		this.numero = numero;
		this.bairro = bairro;
		this.cidade = cidade;
		this.estado = estado;
	}
	
	public void setLogradouro(String logradouro) {
		this.logradouro = logradouro;
	}
	public String getLogradouro() {
		return this.logradouro;
	}
	public void setNumero(int numero) {
		this.numero = numero;
	}
	public int getNumero() {
		return this.numero;
	}
	public void setBairro(String bairro) {
		this.bairro = bairro;
	}
	public String getBairro() {
		return this.bairro;
	}
	public void setCidade(String cidade) {
		this.cidade = cidade;
	}
	public String getCidade() {
		return this.cidade;
	}
	public void setEstado(String estado) {
		this.estado = estado;
	}
	public String getEstado() {
		return this.estado;
	}
	}
