#include<stdio.h>
#include<conio.h>
#include<iostream>
#include<locale.h>
using namespace std;
int main ()
{
	setlocale(LC_ALL,"Portuguese");
	int idade;
	cout<<"Digite a idade da pessoa: ";
	cin>>idade;
	if (idade>=18)
	{
		cout<<"\nEssa pessoa é maior de idade!!!";
	}
	else
	{
		cout<<"\nEssa pessoa é menor de idade!!!";
	}
	getch();
}
