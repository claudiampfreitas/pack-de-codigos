#include<stdio.h>
#include<conio.h>
#include<locale.h>
int main()
{
	setlocale(LC_ALL,"Portuguese");
	float metros,km,cm;
	printf("Digite uma distância em metros: ");
	scanf("%f",&metros);
	printf("\n");
	km=metros/1000;
	cm=metros*100;
	printf("Metros em quilômetros: %0.2f\n",km);
	printf("Metros em centímetros: %0.2f",cm);
	getch();
}
