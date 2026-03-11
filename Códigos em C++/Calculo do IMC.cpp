#include <stdio.h>
#include <conio.h>
#include <math.h>
#include<locale.h>
int main()
{
	setlocale(LC_ALL,"Portuguese");
	float peso,altura,IMC;
	printf ("Digite o seu peso: ");
	scanf ("%f",&peso);
	printf ("Digite a sua altura: ");
	scanf ("%f",&altura);
	IMC=peso/pow(altura,2);
	printf ("O valor do seu IMC é: %0.2f",IMC);
	getch();
}
