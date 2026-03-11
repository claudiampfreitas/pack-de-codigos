#include<stdio.h>
#include<conio.h>
#include<locale.h>
int main()
{
	setlocale(LC_ALL,"Portuguese");
	float distancia,quantcomb,consumo;
	printf("Qual a distância percorrida? (em km): ");
	scanf("%f",&distancia);
	printf("Qual a quantidade de combustível usada? (em l): ");
	scanf("%f",&quantcomb);
	printf("\n");
	consumo=distancia/quantcomb;
	printf("Consumo do veículo em km/l: %0.2f",consumo);
	getch();
}
