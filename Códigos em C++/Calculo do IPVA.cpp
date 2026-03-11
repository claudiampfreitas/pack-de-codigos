#include <stdio.h>
#include <conio.h>
#include<locale.h>
int main()
{
	setlocale(LC_ALL,"Portuguese");
	float valor,ipva;
	printf ("Digite o valor do seu veículo: ");
	scanf ("%f",&valor);
	ipva=4*valor/100;
	printf ("O valor do seu IPVA: %0.2f",ipva);
	getch();
}
