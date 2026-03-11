#include<conio.h>
#include<stdio.h>
#include<iostream>
#include<locale.h>
using namespace std;
int main()
{   
    setlocale(LC_ALL,"Portuguese");
	float salbase,salnovo;
	cout<<"Digite o valor do seu salário: ";
	cin>>salbase;
	if(salbase<=3000)
	{
		salnovo=salbase*1.04;
		cout<<"O novo salário é: "<<salnovo;
	}
	else
	{
		salnovo=salbase*1.03;
		cout<<"O novo salário é: "<<salnovo;
	}
	getch();
}
	
