#include<iostream>
#include<stdio.h>
#include<conio.h>
#include<locale.h>

using namespace std;
int main()
{
setlocale(LC_ALL,"Portuguese");
char cod;
float valv,ipva;

cout<<"Código da categoria:";
cout<<"\n";
cout<<"\n";
cout<<"A - Automóveis, utilitários, caminhonetes cabine dupla \nB - Pick-ups e furgões de carga \nC - Taxi, escolar \nD - Motocicletas \nE - Veículos de locadoras \nF - Ônibus, micro ônibus, caminhão, trator";
cout<<"\n";
cout<<"\n";
cout<<"Escolha uma categoria de A a F: ";
cin>>cod;
cout<<"\nQual o valor do veículo? ";
cin>>valv;
cout<<"\n";

switch (cod)
{
case 'A':
case 'a':
ipva=valv*0.04;
cout<<"O valor do IPVA é de: "<<ipva;
break;

case 'B':
case 'b':
ipva=valv*0.03;
cout<<"O valor do IPVA é de: "<<ipva;
break;

case 'C':
case 'c':
ipva=valv*0.02;
cout<<"O valor do IPVA é de: "<<ipva;
break;
	
case 'D':
case 'd':
ipva=valv*0.02;
cout<<"O valor do IPVA é de: "<<ipva;
break;

case 'E':
case 'e':
ipva=valv*0.01;
cout<<"O valor do IPVA é de: "<<ipva;
break;

case 'F':
case 'f':
ipva=valv*0.01;
cout<<"O valor do IPVA é de: "<<ipva;
break;
   		
default:
cout<<"Você digitou um código inválido!!!";
break;
}
getch();
}

