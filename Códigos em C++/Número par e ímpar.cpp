#include<stdio.h>
#include<conio.h>
#include<iostream>
#include<locale.h>
using namespace std;
int main ()
{
	setlocale(LC_ALL,"Portuguese");
	int numero;
	cout<<"Digite um número inteiro: ";
	cin>>numero;
	if (numero%2==0)
	{
		cout<<"Este número é par!!!";
	}
	else
	{
		cout<<"Este número é ímpar!!!";
	}
	getch();
}
