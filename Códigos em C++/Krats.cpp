#include<conio.h>
#include<stdio.h>
#include<locale.h>
#include<iostream>
using namespace std;
int main ()
{
setlocale(LC_ALL,"Portuguese");
int insc,qtdf=0;
float hn,he,sb1,sb2,sbt,inss,sl,totfp=0;

while(true)
{
cout<<"Qual a inscrição do funcionário? (0 para finalizar): ";
cin>>insc;
if (insc==0)
break;
cout<<"Quantas horas normais trabalhadas? ";
cin>>hn;
cout<<"Quantas horas extras trabalhadas? ";
cin>>he;
sb1=hn*25.50;
sb2=he*37.45;
sbt=sb1+sb2;
cout<<"\nSeu salário bruto é de: "<<sbt;
inss=sbt*0.11;
cout<<"\nO desconto do INSS é de: "<<inss;
sl=sbt-inss;
cout<<"\nSeu salário líquido é de: "<<sl;
cout<<"\n";
cout<<"\n";
qtdf++;
totfp+=sbt;
}
cout<<"\nA empresa Krats tem "<<qtdf<<" funcionários";
cout<<"\nO total da folha de pagamento é de: "<<totfp;
getch();
}
