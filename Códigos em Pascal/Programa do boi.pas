program bois;
var
numero,gordo,magro:integer;
peso,pesomenor,pesomaior:real;

begin
pesomenor:=9999999;
pesomaior:=0;
writeln('Qual o numero do boi? 0=fim');
readln(numero);
while (numero>0) do
begin
writeln('Qual o peso do boi? ');
readln(peso);
if (peso>pesomaior) then
begin
pesomaior:=peso;
gordo:=numero;
end;
if (peso<pesomenor) then
begin
pesomenor:=peso;
magro:=numero;
end;
writeln;
writeln('Qual a identificação do proximo boi? 0=fim');
readln(numero);
end;
writeln;
writeln('Qual o boi mais gordo: ', gordo);
writeln('Qual o peso maior: ', pesomaior:0:2);
writeln('Qual o boi mais magro: ', magro);
writeln('Qual o peso menor: ', pesomenor:0:2);
readln;
end.