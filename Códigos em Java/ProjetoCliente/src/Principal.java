
public class Principal {

	public static void main(String[] args) {
		
		//Instância da classe
		ClienteEscola ce1 = new ClienteEscola (01, "João Eloi", "012.123.234-45", "10/05/2000", "solteiro", "Rua Dois, 45, bairro Algum, BH - MG", "brasileiro", "(31) 98465-7755");
		ce1.ExibirCadastro();
		ce1.ConsultarNotas();
		System.out.println();
		ClienteEscola ce2 = new ClienteEscola (02, "Cláudia Mônica", "123.456.789-01", "20/07/1990", "casada", "Rua Vinte, 200, bairro Nenhum, BH - MG", "brasileira", "(31) 98888-8888");
		ce2.ExibirCadastro();
		ce2.ConsultarNotas();
		System.out.println();
		ClienteEscola ce3 = new ClienteEscola (03, "Nicole", "987.654.321-10", "10/09/2005", "solteira", "Rua Atenas, 150, bairro do Gato, BH - MG", "brasileira", "(31) 98974-2103");
		ce3.ExibirCadastro();
		ce3.ConsultarNotas();
		System.out.println();
		ClienteEscola ce4 = new ClienteEscola (04, "Renan", "000.111.222-33", "25/06/2010", "solteiro", "Rua Milão, 450, bairro sem nome, BH - MG", "brasileiro", "(31) 90101-0101");
		ce4.ExibirCadastro();
		ce4.ConsultarNotas();
		System.out.println();
		ClienteEscola ce5 = new ClienteEscola (05, "Victor", "444.555.666-77", "28/12/1999", "solteiro", "Rua Brasil, 175, bairro São Paulo, BH - MG", "brasileiro", "(31) 98574-9631");
		ce5.ExibirCadastro();
		ce5.ConsultarNotas();
	}

}
