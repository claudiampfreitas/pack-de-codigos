public class Main {

	public static void main(String[] args) {
		
		ContaCorrente cc = new ContaCorrente();
		
		cc.id = 10;
		cc.titular = "João";
		cc.numero_conta = "15054-8";
		cc.agencia = 1019;
		cc.saldo = 150.0;
		cc.desc_iof = 4.5;
		
		cc.ExibirInfo();
		
		ContaPoupanca cp = new ContaPoupanca();
		
		cp.id = 20;
		cp.titular = "Diogo";
		cp.numero_conta = "18679-3";
		cp.agencia = 2020;
		cp.saldo = 75.50;
		cp.juros_rendimento = 10.0;
		
		cp.ExibirInfo();
	}

}