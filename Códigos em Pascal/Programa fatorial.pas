program Fatorial;
var n,x,Contador,fatorial:integer;
begin
writeln('');
writeln('Calculo do fatorial de um numero');
writeln('');
writeln('Entre com um inteiro nao-negativo: ');
read(n);
fatorial:=1;
Contador:=1;
repeat
fatorial:=fatorial*Contador;
Contador:=Contador+1
until Contador > n;
writeln('O valor de ',n,'!: ',fatorial);
readln;
end.