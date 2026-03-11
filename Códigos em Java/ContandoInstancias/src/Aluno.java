public class Aluno {
    private static int contador = 0;
    private int id;
    private String nome;

    public Aluno(String nome) {
        contador++;
        this.id = contador;
        this.nome = nome;
    }

    public int getId() {
        return id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    @Override
    public String toString() {
        return "Aluno " + id + ": " + nome;
    }

	public static int getNumInstancias() {
		return contador;
	}
}