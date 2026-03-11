
public abstract class Funcionario {

	private int id;
    private String nome;
    private String telefone;
    private double salario;
    private String funcao;
    
	public Funcionario(int id, String nome, String telefone, double salario, String funcao) {
		super();
		this.id = id;
		this.nome = nome;
		this.telefone = telefone;
		this.salario = salario;
		this.funcao = funcao;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getTelefone() {
		return telefone;
	}

	public void setTelefone(String telefone) {
		this.telefone = telefone;
	}

	public double getSalario() {
		return salario;
	}

	public void setSalario(double salario) {
		this.salario = salario;
	}

	public String getFuncao() {
		return funcao;
	}

	public void setFuncao(String funcao) {
		this.funcao = funcao;
	}
	
	public double Bonificacao() {
		return salario * 0.1;
	}
	
	public abstract double add_salario();
	
	@Override
	public String toString() {
		return "Funcionario [id=" + id + ", nome=" + nome + ", telefone=" + telefone + ", salario=" + salario
				+ ", funcao=" + funcao + "]";
	}
}
