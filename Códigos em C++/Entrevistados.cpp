#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<iostream>
using namespace std;
int main ()
{
setlocale(LC_ALL,"Portuguese");
int idade,cont=0,soma=0,npart=0;
float renda,idmedia;

while(true)
{
cout<<"Qual a idade? (<=0 para finalizar) ";
cin>>idade;
if (idade<=0)
break;
cout<<"Qual sua renda mensal? ";
cin>>renda;
if ((idade>45)&&(renda>5000))
cont++;
soma+=idade;
npart++;
}
idmedia=(float)soma/npart;;
cout<<"\nA pesquisa teve "<<npart<<" participantes";
cout<<"\nA idade média dos entrevistados é: "<<idmedia;
cout<<"\nSão "<<cont<<" pessoas com mais de 45 anos e renda maior do que R$ 5000 reais";
getch();
}
