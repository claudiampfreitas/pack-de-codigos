#include<conio.h>
#include<stdio.h>
#include<iostream>
#include<math.h>
#include<locale.h>

using namespace std;

int main ()
{
setlocale(LC_ALL,"Portuguese");

int numero;
float peso,altura,imc;
cout<<"Digite o número de inscrição do atleta ou 0 para sair: ";
cin>>numero;
while (numero!=0)
{
cout<<"Digite o peso do atleta: ";
cin>>peso;
cout<<"Digite a altura do atleta: ";
cin>>altura;
imc=peso/pow(altura,2);
cout<<"\nIMC deste atleta: "<<imc;
cout<<"\n";
cout<<"\nDigite o número de inscrição do atleta ou 0 para sair: ";
cin>>numero;
}
getch();
}
