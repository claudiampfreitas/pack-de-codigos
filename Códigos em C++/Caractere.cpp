#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<iostream>
using namespace std;
int main ()
{
setlocale(LC_ALL,"Portuguese");
char val;
int numcar=0,numast=0;

while(true)
{
cout<<"Qual o caractere digitado? (? para finalizar) ";
cin>>val;
if (val=='?')
break;
numcar++;
if (val=='@')
cout<<"Olha o arroba aí\n";
if (val=='*')
numast++;
}
cout<<"\nForam "<<numcar<<" caracteres digitados";
cout<<"\nForam "<<numast<<" asteriscos digitados";
getch();
}
