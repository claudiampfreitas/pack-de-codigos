
import java.util.Random;

public class Computador extends Jogador {
	
	private Random random = new Random();

	public Computador(int jogador) {
		super(jogador);
		System.out.println("Jogador 'Computador' criado!");
	}

	@Override
	public void jogar(Tabuleiro tabuleiro) {
		Tentativa(tabuleiro);
		tabuleiro.setPosicao(tentativa, jogador);
	}

	@Override
	public void Tentativa(Tabuleiro tabuleiro) {
		do {
			tentativa[0] = random.nextInt(3);
			tentativa[1] = random.nextInt(3);
		} while (!checaTentativa(tentativa, tabuleiro));
	}
}