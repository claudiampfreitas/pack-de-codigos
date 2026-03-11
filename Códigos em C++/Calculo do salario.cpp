#include <stdio.h>
#include <conio.h>
#include<locale.h>
int main()
{
	setlocale(LC_ALL,"Portuguese");
	int numaulas;
	float salbase,contprev,salliq;
	printf ("Quantas aulas foram dadas?: ");
	scanf ("%d",&numaulas);
	salbase=27.50*numaulas;
	contprev=11*salbase/100;
	salliq=salbase-contprev;
	printf("\n");
	printf ("Seu salário base é: %0.2f",salbase);
	printf ("\nSua contribuição previdenciária foi de: %0.2f",contprev);
	printf ("\nO valor do seu salário líquido é: %0.2f",salliq);
	getch();
}
