public class Operador extends Funcionario{

	private double adicional_noturno;

	public Operador(int id, String nome, String telefone, double salario, String funcao, double adicional_noturno) {
		super(id, nome, telefone, salario, funcao);
		this.adicional_noturno = adicional_noturno;
	}

	public double getAdicional_noturno() {
		adicional_noturno = salario * 0.10 + 500;
		return adicional_noturno;
	}

	public void setAdicional_noturno(double adicional_noturno) {
		this.adicional_noturno = adicional_noturno;
	}

	@Override
	public double CalcularBonificacao() {
		double bonificacao = salario * 0.10;
		return bonificacao;
	}

	@Override
	public String toString() {
		return "Operador [adicional_noturno=" + adicional_noturno + ", CalcularBonificacao()=" + CalcularBonificacao()
				+ ", getId()=" + getId() + ", getNome()=" + getNome() + ", getTelefone()=" + getTelefone()
				+ ", getSalario()=" + getSalario() + ", getFuncao()=" + getFuncao() + "]";
	}
}
