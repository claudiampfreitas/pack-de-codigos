#include<conio.h>
#include<stdio.h>
#include<iostream>
#include<locale.h>
using namespace std;
int main ()
{
	setlocale(LC_ALL,"Portuguese");
	float numero,soma=0,media;
	int ab10=0,cont=0;
	
	do
	{
		cout<<"Digite um número (0 para encerrar) ";
		cin>>numero;
		if (numero==0)
		break;
		soma+=numero;
		cont++;
		if (numero<10)
		ab10++;		
	}
	while (true);
	media=soma/cont;
	cout<<"\nSoma: "<<soma;
	cout<<"\nMédia: "<<media;
	cout<<"\nQuantidade de valores abaixo de 10: "<<ab10;
	cout<<"\nQuantidade de números digitados: "<<cont;
	getch();
}
