#include<conio.h>
#include<stdio.h>
#include<iostream>
#include<math.h>
#include<locale.h>

using namespace std;

int main ()
{
setlocale(LC_ALL,"Portuguese");

int numero,ct;
float peso,altura,imc;
for(ct=1;ct<=15;ct++)
{
cout<<"Digite o número de inscrição do atleta: ";
cin>>numero;
cout<<"Digite o peso do atleta: ";
cin>>peso;
cout<<"Digite a altura do atleta: ";
cin>>altura;
imc=peso/pow(altura,2);
cout<<"\nIMC deste atleta: "<<imc;
cout<<"\n";
cout<<"\n";
}
getch();
}
