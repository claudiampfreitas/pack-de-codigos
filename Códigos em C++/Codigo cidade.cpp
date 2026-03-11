#include<iostream>
#include<stdio.h>
#include<conio.h>
#include<locale.h>

using namespace std;
int main()
{
setlocale(LC_ALL,"Portuguese");
int cod;
float vini,vfinal;

cout<<"Código da cidade:";
cout<<"\n";
cout<<"\n";
cout<<"1 - Belo Horizonte, Contagem, Betim \n2 - Sabará, Nova Lima, Raposos, Caeté \n3 - Itabirito, Ouro Preto, Mariana, Congonhas \n4 - Sete Lagoas, Curvelo";
cout<<"\n";
cout<<"\n";
cout<<"Escolha um valor de 1 a 4: ";
cin>>cod;
cout<<"\n";

switch (cod)
{
case 1:
cout<<"Qual o valor da encomenda? ";
cin>>vini;
vfinal=vini*0.01;
cout<<"O valor da entrega é de: "<<vfinal;
break;

case 2:
cout<<"Qual o valor da encomenda? ";
cin>>vini;
vfinal=vini*0.02;
cout<<"O valor da entrega é de: "<<vfinal;
break;

case 3:
cout<<"Qual o valor da encomenda? ";
cin>>vini;
vfinal=vini*0.03;
cout<<"O valor da entrega é de: "<<vfinal;
break;
	
case 4:
cout<<"Qual o valor da encomenda? ";
cin>>vini;
vfinal=vini*0.04;
cout<<"O valor da entrega é de: "<<vfinal;
break;
   		
default:
cout<<"Você digitou um código inválido!!!";
break;
}
getch();
}

