#include<stdio.h>
#include<conio.h>
#include<iostream>
#include<locale.h>
#include<math.h>
using namespace std;
int main()
{
	setlocale(LC_ALL,"Portuguese");
	int numero,quadrado;
	float raizquadrada;
	
	for (numero=1;numero<=500;numero++)
	{
		quadrado=numero*numero;
		raizquadrada=sqrt(numero);
		cout<<"Número: "<<numero;
		cout<<"\nSeu quadrado é: "<<quadrado;
		cout<<"\nSua raiz quadrada é: "<<raizquadrada;
		cout<<"\n";
		cout<<"\n";
	}
cout<<"Programa encerrado!!!";
getch(); 	
}
