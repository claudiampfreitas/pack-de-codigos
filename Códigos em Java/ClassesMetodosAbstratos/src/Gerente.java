public class Gerente extends Funcionario{
	
	private double adicional;

	public Gerente(int id, String nome, String telefone, double salario, String funcao, double adicional) {
		super(id, nome, telefone, salario, funcao);
		this.adicional = adicional;
	}

	public double getAdicional() {
		adicional = salario * 0.20;
		return adicional;
	}

	public void setAdicional(double adicional) {
		this.adicional = adicional;
	}

	@Override
	public double CalcularBonificacao() {
		double bonificacao = salario * 0.15;
		return bonificacao;
	}

	@Override
	public String toString() {
		return "Gerente [adicional=" + adicional + ", CalcularBonificacao()=" + CalcularBonificacao() + ", getId()="
				+ getId() + ", getNome()=" + getNome() + ", getTelefone()=" + getTelefone() + ", getSalario()="
				+ getSalario() + ", getFuncao()=" + getFuncao() + "]";
	}
}