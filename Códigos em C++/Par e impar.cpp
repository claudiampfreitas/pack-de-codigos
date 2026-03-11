#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<iostream>
using namespace std;
int main ()
{
setlocale(LC_ALL,"Portuguese");
int numero;

while(true)
{
cout<<"Qual o número digitado? (menor ou igual a 0 para finalizar): ";
cin>>numero;
if (numero<=0)
break;
if (numero%2==0)
cout<<"O número "<<numero<<" é par";
else
cout<<"O número "<<numero<<" é ímpar";
cout<<"\n";
cout<<"\n";
}
}
