#include<conio.h>
#include<stdio.h>
#include<math.h>
#include<locale.h>
int main()
{
	setlocale(LC_ALL,"Portuguese");
	int valor1,valor2,dif,squad;
	printf("Digite o primeiro número: ");
	scanf("%d",&valor1);
	printf("Digite o segundo número: ");
	scanf("%d",&valor2);
	dif=valor1-valor2;
	squad=pow(valor1,2)+pow(valor2,2);
	printf("\nA diferença é: %d", dif);
	printf("\nA soma dos quadrados é: %d", squad);
	getch();
}
