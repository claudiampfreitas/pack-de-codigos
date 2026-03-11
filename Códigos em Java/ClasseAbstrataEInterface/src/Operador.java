public class Operador extends Funcionario implements Func_Patio {

	private double add_noturno;

	public Operador(int id, String nome, String telefone, double salario, String funcao, double add_noturno) {
		super(id, nome, telefone, salario, funcao);
		this.add_noturno = add_noturno;
	}

	public double getAdd_noturno() {
		return add_noturno;
	}

	public void setAdd_noturno(double add_noturno) {
		this.add_noturno = add_noturno;
	}

	@Override
	public double add_salario() {
		
		return (getSalario() + add_noturno) * 0.1;
	}

	@Override
	public String toString() {
		return "Operador [add_noturno=" + add_noturno + ", getId()=" + getId() + ", getNome()=" + getNome()
				+ ", getTelefone()=" + getTelefone() + ", getSalario()=" + getSalario() + ", getFuncao()=" + getFuncao()
				+ ", Bonificacao()=" + Bonificacao() + ", getClass()=" + getClass() + ", hashCode()=" + hashCode()
				+ "]";
	}

	@Override
	public double add_periculosidade() {
		
		return getSalario() * 0.3;
	}
	
}