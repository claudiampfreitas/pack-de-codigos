import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Qual o seu compromisso? ");
		String comp = sc.next();
		System.out.println("Qual o dia agendado? ");
		String dia = sc.next();
		System.out.println("Qual o mês agendado? ");
		String mes = sc.next();
		System.out.println("Qual o ano? ");
		String ano = sc.next();
		System.out.println("Qual a hora marcada? ");
		String hora = sc.next();
		System.out.println("Quantos minutos? ");
		String min = sc.next();
		info (comp, dia, mes, ano, hora, min);
	}
	
	public static String ExibeCompromisso (String c)
	{
		return c;
	}
	
	public static String ExibeData (String d, String m, String a)
	{
		return (d+"/"+m+"/"+a);
	}
	
	public static String ExibeHora (String h, String mi)
	{
		return (h+":"+mi);
	}
	
	public static void info (String c, String d, String m, String a, String h, String mi)
	{
		System.out.println("Nome do compromisso: " +ExibeCompromisso(c));
		System.out.println("Data do compromisso: " +ExibeData(d,m,a));
		System.out.println("Horário do compromisso: " +ExibeHora(h,mi));
	}
	}
