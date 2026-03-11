import java.util.Scanner;

public class ClienteEscola {

	// Atributos
	public int matricula;
	public String nome;
	public String cpf;
	public String datanasc;
	public String estado_civil;
	public String endereco;
	public String nacionalidade;
	public String contato;

	// Construtor
	public ClienteEscola() {

		}

	public ClienteEscola (int matricula, String nome, String cpf, String datanasc, String estado_civil, String endereco, String nacionalidade, String contato) {
			this.matricula = matricula;
			this.nome = nome;
			this.cpf = cpf;
			this.datanasc = datanasc;
			this.estado_civil = estado_civil;
			this.endereco = endereco;
			this.nacionalidade = nacionalidade;
			this.contato = contato;
		}

	// Métodos
	public void RealizarMatricula() {
		System.out.println("Sua matrícula foi efetivada com sucesso!!");
	}
	public void CancelarMatricula() {
		System.out.println("Sua matrícula foi cancelada com sucesso!!");
	}
	public void RealizarAtividades() {

	}
	public void AprenderMaterias() {
		
	}
	public void RealizarProvas() {
		
	}
	public void RealizarApresentacoes() {
		
	}
	public void RealizarTrabalhos() {
		
	}
	public void PagarMensalidade() {
		
	}
	public void CumprirHorarios() {
		
	}
	public void ConsultarNotas() {
		Scanner sc = new Scanner(System.in);
		System.out.print("Qual é a nota final obtida? ");
		double notafinal = sc.nextDouble();
		if (notafinal>60)
			System.out.println("Você foi aprovado!!!");
		else if (notafinal==60)
			System.out.println("Você está de recuperação!!!");
		else
			System.out.println("Você foi reprovado!!!");
	}
	public void ExibirCadastro() {
		System.out.println("Matrícula do aluno: " +this.matricula);
		System.out.println("Nome do aluno: " +this.nome);
		System.out.println("CPF: " +this.cpf);
		System.out.println("Data de nascimento: " +this.datanasc);
		System.out.println("Estado civil: " +this.estado_civil);
		System.out.println("Endereço: " +this.endereco);
		System.out.println("Nacionalidade: " +this.nacionalidade);
		System.out.println("Contato: " +this.contato);
		System.out.println();
	}

}