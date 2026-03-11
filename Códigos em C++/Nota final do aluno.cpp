#include<iostream>
#include<stdio.h>
#include<conio.h>
#include<locale.h>

using namespace std;
int main()
{
setlocale(LC_ALL,"Portuguese");
int mat,n1,n2,n3,nfin;

cout<<"Qual a matrícula do aluno? ";
cin>>mat;
cout<<"\nQual a nota da primeira prova? ";
cin>>n1;
cout<<"Qual a nota da segunda prova? ";
cin>>n2;
cout<<"Qual a nota da terceira prova? ";
cin>>n3;
nfin=n1+n2+n3;
cout<<"\nA sua nota final é de: "<<nfin;
cout<<"\n";

switch (nfin)
{
case 0 ... 3:
cout<<"Sua nota está muito baixa";
break;

case 4 ... 5:
cout<<"Sua nota está baixa";
break;

case 6 ... 7:
cout<<"Sua nota está dentro da média";
break;
	
case 8 ... 10:
cout<<"Sua nota está alta";
break;
   		
default:
cout<<"Você digitou uma nota inválida!!!";
break;
}
getch();
}

