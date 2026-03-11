public class Main {
	
	public static void main(String[] args) {
		Aluno aluno1 = new Aluno("João");
		Aluno aluno2 = new Aluno("Maria");
		Aluno aluno3 = new Aluno("Pedro");

		System.out.println(aluno1);
		System.out.println(aluno2);
		System.out.println(aluno3);
		System.out.println();
		System.out.println("Número de instâncias criadas: " + Aluno.getNumInstancias());
	}
}