#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<iostream>
using namespace std;
int main()
{
	setlocale(LC_ALL,"Portuguese");
	float numero;
	cout<<"Digite o número: ";
	cin>>numero;
	if(numero>0)
	{
		cout<<"O número digitado é positivo";
	}
	else if(numero==0)
	{
		cout<<"O número digitado é nulo";
    }
	else
	{
		cout<<"O número digitado é negativo";
	}
	getch();
}
