public class Secretaria extends Funcionario {
	
	private double add_especial;

	public Secretaria(int id, String nome, String telefone, double salario, String funcao, double add_especial) {
		super(id, nome, telefone, salario, funcao);
		this.add_especial = add_especial;
	}

	public double getAdd_especial() {
		return add_especial;
	}

	public void setAdd_especial(double add_especial) {
		this.add_especial = add_especial;
	}

	@Override
	public double add_salario() {
		
		return (getSalario() + add_especial) * 0.1;
	}

	@Override
	public String toString() {
		return "Secretaria [add_especial=" + add_especial + ", getId()=" + getId() + ", getNome()=" + getNome()
				+ ", getTelefone()=" + getTelefone() + ", getSalario()=" + getSalario() + ", getFuncao()=" + getFuncao()
				+ ", Bonificacao()=" + Bonificacao() + ", getClass()=" + getClass() + ", hashCode()=" + hashCode()
				+ "]";
	}

}