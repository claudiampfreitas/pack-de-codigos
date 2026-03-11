public class Secretaria extends Funcionario{
	
	private double adicional_especial;

	public Secretaria(int id, String nome, String telefone, double salario, String funcao, double adicional_especial) {
		super(id, nome, telefone, salario, funcao);
		this.adicional_especial = adicional_especial;
	}

	public double getAdicional_especial() {
		adicional_especial = salario * 0.10 + 1000;
		return adicional_especial;
	}

	public void setAdicional_especial(double adicional_especial) {
		this.adicional_especial = adicional_especial;
	}

	@Override
	public double CalcularBonificacao() {
		double bonificacao = 1700 * 0.10;
		return bonificacao;
	}

	@Override
	public String toString() {
		return "Secretaria [adicional_especial=" + adicional_especial + ", CalcularBonificacao()="
				+ CalcularBonificacao() + ", getId()=" + getId() + ", getNome()=" + getNome() + ", getTelefone()="
				+ getTelefone() + ", getSalario()=" + getSalario() + ", getFuncao()=" + getFuncao() + "]";
	}
}