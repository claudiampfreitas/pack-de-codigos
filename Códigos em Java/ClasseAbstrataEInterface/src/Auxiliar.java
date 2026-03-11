public class Auxiliar extends Funcionario implements Func_Patio {

	public Auxiliar(int id, String nome, String telefone, double salario, String funcao) {
		super(id, nome, telefone, salario, funcao);
		
	}

	@Override
	public double add_periculosidade() {
		
		return getSalario() * 0.3;
	}

	@Override
	public double add_salario() {
		
		return getSalario() * 0.1;
	}

	@Override
	public String toString() {
		return "Auxiliar [add_periculosidade()=" + add_periculosidade() + ", getId()=" + getId() + ", getNome()="
				+ getNome() + ", getTelefone()=" + getTelefone() + ", getSalario()=" + getSalario() + ", getFuncao()="
				+ getFuncao() + ", Bonificacao()=" + Bonificacao() + ", getClass()=" + getClass() + ", hashCode()="
				+ hashCode() + "]";
	}

}
