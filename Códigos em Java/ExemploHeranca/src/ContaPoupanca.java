public class ContaPoupanca extends ContaBancaria{
	
	public double juros_rendimento;
	
	public ContaPoupanca() {
		
	}
	
	public ContaPoupanca (int id, String titular, String numero_conta, int agencia, double saldo, double juros_rendimento) {
		
		this.id = id;
		this.titular = titular;
		this.numero_conta = numero_conta;
		this.agencia = agencia;
		this.saldo = saldo;
		this.juros_rendimento = juros_rendimento;
	}
	
	public void ExibirInfo () {
		System.out.println();
		System.out.println("ID do titular: " +this.id);
		System.out.println("Titular da conta: " +this.titular);
		System.out.println("Número da conta: " +this.numero_conta);
		System.out.println("Agência: " +this.agencia);
		System.out.println("Saldo atual: " +this.saldo);
		System.out.println("Juros de rendimento: " +this.juros_rendimento);
	}
}