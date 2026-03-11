import java.util.Random;

public class Main {

	public static void main(String[] args) {
		//Nome: Cláudia Mônica Peixoto Freitas
		Random rand = new Random();
		int mat[][] = new int[5][5];
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				mat[i][j] = rand.nextInt(10, 50);
			}
		}
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				System.out.print("  " + mat[i][j] + "  ");
			}
			System.out.println();
		}
		System.out.println();
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (i == j) {
					mat[i][j] = 1;
					System.out.print(mat[i][j] + "  ");
				} else {
					System.out.print("  ");
				}
			}
			System.out.println();

		}
		System.out.println();
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (i + j == 4) {
					mat[i][j] = 1;
					System.out.print(mat[i][j] + "  ");
				} else {
					System.out.print("  ");
				}
			}
			System.out.println();

		}
		System.out.println();
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if ((i == j) || (i + j == 4)) {
					mat[i][j] = 1;
					System.out.print(mat[i][j] + "  ");
				} else {
					System.out.print("   ");
				}
			}
			System.out.println();
		}
		System.out.println();
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if ((j == 2) || (i == 2)) {
					mat[i][j] = 1;
					System.out.print(mat[i][j] + "  ");
				} else {
					System.out.print("   ");
				}
			}
			System.out.println();
		}
		System.out.println();
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (i + j >= 4) {
					mat[i][j] = 0;
					System.out.print(mat[i][j] + "  ");
				} else {
					System.out.print("   ");
				}
			}
			System.out.println();
		}
		System.out.println();
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (i >= j) {
					mat[i][j] = 0;
					System.out.print(mat[i][j] + "  ");
				} else {
					System.out.print("  ");
				}
			}
			System.out.println();
		}
		System.out.println();
		int soma = 0;

		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (i == j) {
					mat[i][j] = 1;
				} else {
					mat[i][j] = 0;
				}
			}
		}
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				if (i == j) {
					soma = soma + mat[i][j];
				}
			}
		}
		for (int i = 0; i < 5; i++) {
			for (int j = 0; j < 5; j++) {
				System.out.print("  " + mat[i][j] + "  ");
			}
			System.out.println();
		}
		System.out.println();
		System.out.println("A soma da diagonal principal é: " + soma);

	}

}
