public class ContaCorrente extends ContaBancaria{
	
	public double desc_iof;
	
	public ContaCorrente() {
		
	}
	
	public ContaCorrente (int id, String titular, String numero_conta, int agencia, double saldo, double desc_iof)
	{
		this.id = id;
		this.titular = titular;
		this.numero_conta = numero_conta;
		this.agencia = agencia;
		this.saldo = saldo;
		this.desc_iof = desc_iof;
	}
	
	public void ExibirInfo () {
		System.out.println("ID do titular: " +this.id);
		System.out.println("Titular da conta: " +this.titular);
		System.out.println("Número da conta: " +this.numero_conta);
		System.out.println("Agência: " +this.agencia);
		System.out.println("Saldo atual: " +this.saldo);
		System.out.println("Desconto do IOF: " +this.desc_iof);
	}
}