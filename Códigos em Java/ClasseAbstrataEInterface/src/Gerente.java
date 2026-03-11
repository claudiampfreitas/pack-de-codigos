public class Gerente extends Funcionario {

	public Gerente(int id, String nome, String telefone, double salario, String funcao) {
		super(id, nome, telefone, salario, funcao);
	}

	@Override
	public double add_salario() {
		
		return getSalario() * 0.1;
	}
	
	public double bonificacao() {
		
		return getSalario() * 0.15;
	}

	@Override
	public String toString() {
		return "Gerente [getId()=" + getId() + ", getNome()=" + getNome() + ", getTelefone()=" + getTelefone()
				+ ", getSalario()=" + getSalario() + ", getFuncao()=" + getFuncao() + ", Bonificacao()=" + Bonificacao()
				+ ", getClass()=" + getClass() + ", hashCode()=" + hashCode() + "]";
	}

}