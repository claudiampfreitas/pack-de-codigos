#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<math.h>
int main()
{   
    setlocale(LC_ALL,"Portuguese");
	float a,b,c,delta,x1,x2;
	printf("Entre com o valor do coeficiente A: ");
	scanf("%f",&a);
	printf("Entre com o valor do coeficiente B: ");
	scanf("%f",&b);
	printf("Entre com o valor do coeficiente C: ");
	scanf("%f",&c);
	printf("\n");
if (a!=0) {
	delta=pow(b,2)-4*a*c;
	if (delta==0) {
	    x1=(-b+sqrt(delta))/(2*a);
	    printf("O delta é igual a 0\n");
	    printf("x1 e x2 = %.2f\n", x1);
    } else {
	  if (delta>0) {
	    x1=(-b+sqrt(delta))/(2*a);
	    x2=(-b-sqrt(delta))/(2*a);
	    printf("O delta é maior que 0\n");
	    printf("x1 = %.2f\n", x1);
	    printf("x2 = %.2f\n", x2);
	  } else {
	    printf("O delta é menor que 0\n");
	    printf("Não existe raiz real!!\n");
	}
}
    } else {
	    printf("Não é uma equação do segundo grau\n");
	    printf("O coeficiente A deve ser diferente de 0\n");
}
getch();
}
