#include<conio.h>
#include<stdio.h>
#include<iostream>
#include<locale.h>

using namespace std;

int main ()
{
setlocale(LC_ALL,"Portuguese");

float vbase,valtura,varea,perimetro;

cout<<"Digite a medida da base: ";
cin>>vbase;
cout<<"Digite a medida da altura: ";
cin>>valtura;
varea=vbase*valtura;
perimetro=2*vbase+2*valtura;
cout<<"\n";
cout<<"A medida da área é de: "<<varea;
cout<<"\nA medida do perímetro é de: "<<perimetro;
getch();
}
