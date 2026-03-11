#include <stdio.h>
#include <conio.h>
#include<locale.h>
int main ()
{ 
setlocale(LC_ALL,"Portuguese");
float milhas,metros,km,jardas;
printf("Digite os km para conversão: ");
scanf("%f",&km);
milhas=km*0.621;
metros=km*1000;
jardas=km*1093.61;
printf("\n");
printf("A conversão em milhas é: %0.2f",milhas);
printf("\nA conversão em metros é: %0.2f",metros);
printf("\nA conversão em jardas é: %0.2f",jardas);
getch();
}
