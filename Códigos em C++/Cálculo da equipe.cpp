#include <conio.h>
#include <stdio.h>
#include<locale.h>
int main()
{
	setlocale(LC_ALL,"Portuguese");
	int nvit,nemp,nder,ngolsm,ngolssf;
	int njogosd,pontequ,saldgols;
	float mgolsm,mgolssf; 
	printf("Quantas partidas vencidas?: ");
	scanf("%d",&nvit);
	printf("Quantas partidas empatadas?: ");
	scanf("%d",&nemp);
	printf("Quantas derrotas sofridas?: ");
	scanf("%d",&nder);
	printf("Quantos gols marcados?: ");
	scanf("%d",&ngolsm);	
	printf("Quantos gols sofridos?: ");
	scanf("%d",&ngolssf);
	printf("\n");
njogosd=nvit+nemp+nder;
pontequ=nvit*3+nemp*1;
saldgols=ngolsm-ngolssf;
mgolsm=(float)ngolsm/njogosd;
mgolssf=(float)ngolssf/njogosd;
printf("O número de jogos disputados é: %d",njogosd);
printf("\nA pontuação da equipe é: %d",pontequ);
printf("\nO saldo de gols foi: %d",saldgols);
printf("\nA média de gols marcados foi: %0.2f",mgolsm);
printf("\nA média de gols sofridos foi: %0.2f",mgolssf);
getch();
}

