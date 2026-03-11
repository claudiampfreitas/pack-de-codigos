#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<iostream>
#include<math.h>
using namespace std;
int main ()
{
setlocale(LC_ALL,"Portuguese");
float numero,quad,rquad;

while(true)
{
cout<<"Qual o número digitado? (menor ou igual a 0 para finalizar): ";
cin>>numero;
if (numero<=0)
break;
quad=pow(numero,2);
rquad=sqrt(numero);
cout<<"O quadrado do número é: "<<quad;
cout<<"\nA raíz quadrada do número é: "<<rquad;
cout<<"\n";
cout<<"\n";
}
}
