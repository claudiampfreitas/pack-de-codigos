#include<conio.h>
#include<stdio.h>
#include<iostream>
#include<locale.h>
using namespace std;
int main()
{   
    setlocale(LC_ALL,"Portuguese");
    float p1,p2,p3,pfinal;
    cout<<"Digite o peso 1: ";
    cin>>p1;
    cout<<"Digite o peso 2: ";
    cin>>p2;
    cout<<"Digite o peso 3: ";
    cin>>p3;
    pfinal=(p1+p2+p3)/3;
    cout<<"\nA média entre os 3 pesos é de: "<<pfinal;
    if (pfinal<=100)
    {
    	cout<<"\nO peso final é muito instável";
	}
	else if((pfinal>100)&&(pfinal<250))
	{
		cout<<"\nO peso final é pouco instável";
	}
	else
	{
		cout<<"\nO peso final é estável";
	}
getch();
}
