#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<iostream>
using namespace std;
int main ()
{
setlocale(LC_ALL,"Portuguese");
int numpost,nppart=0;
float peta,pgas,reg,sreg=0,porc;

while(true)
{
cout<<"Qual o número do posto? (0 para finalizar) ";
cin>>numpost;
if (numpost==0)
break;
cout<<"Qual o preço do etanol? ";
cin>>peta;
cout<<"Qual o preço da gasolina? ";
cin>>pgas;
reg=(peta*100/pgas);
cout<<"\nA relação etanol-gasolina é de: "<<reg;
cout<<"\n";
cout<<"\n";
if (reg>70)
sreg++;
nppart++;
}
porc=(sreg*100/nppart);
cout<<"\nSão "<<sreg<<" postos com a relação etanol-gasolina acima de 70";
cout<<"\nSão "<<nppart<<" participando da pesquisa";
cout<<"\nSão "<<porc<<"% de postos com a relação etanol-gasolina acima de 70";
getch();
}
