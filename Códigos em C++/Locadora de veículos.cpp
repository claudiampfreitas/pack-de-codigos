#include<conio.h>
#include<stdio.h>
#include<iostream>
#include<locale.h>
using namespace std;
int main ()
{
	setlocale(LC_ALL,"Portuguese");
	float val,ipva,somaipva=0;
	int cod,contv=0;
	
	do
	{
		cout<<"Digite o código do veículo (9999 para encerrar): ";
		cin>>cod;
		if (cod==9999)
		break;
		cout<<"Digite o valor do veículo: ";
		cin>>val;
		ipva=val*0.01;
		cout<<"\nO IPVA foi de: "<<ipva;
		cout<<"\n";
		cout<<"\n";
		contv++;
		somaipva+=ipva;		
	}
	while (true);
	cout<<"\nA locadora possui "<<contv<<" veículos";
	cout<<"\nA soma dos ipva's foi de: "<<somaipva;
	getch();
}
