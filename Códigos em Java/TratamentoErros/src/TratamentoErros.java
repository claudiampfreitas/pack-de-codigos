public class TratamentoErros {

	public static void main(String[] args) {
		int [] v = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
		
		try {
			for (int i = 0; i <= 10; i++) {
				System.out.println(v[i]);
			}
		}
		catch (ArrayIndexOutOfBoundsException e){
			System.out.println();
			System.out.println("Índice fora do intervalo!! " +e.getMessage());
		}
	}
}