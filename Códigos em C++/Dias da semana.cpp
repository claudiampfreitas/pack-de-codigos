#include<iostream>
#include<stdio.h>
#include<conio.h>
#include<locale.h>

using namespace std;
int main()
{
setlocale(LC_ALL,"Portuguese");
int num;

cout<<"1 - Domingo \n2 - Segunda-feira \n3 - Terça-feira \n4 - Quarta-feira \n5 - Quinta-feira \n6 - Sexta-feira \n7 - Sábado";
cout<<"\n";
cout<<"\nEscolha um número de 1 a 7: ";
cin>>num;

switch (num)
{
case 1:
cout<<"O dia da semana é Domingo";
break;

case 2:
cout<<"O dia da semana é Segunda-feira";
break;

case 3:
cout<<"O dia da semana é Terça-feira";
break;
	
case 4:
cout<<"O dia da semana é Quarta-feira";
break;
	
case 5:
cout<<"O dia da semana é Quinta-feira";
break;
   
case 6:
cout<<"O dia da semana é Sexta-feira";
break;
   	
case 7:
cout<<"O dia da semana é Sábado";
break;
   		
default:
cout<<"Você digitou um valor inválido!!!";
break;
}
getch();
}

