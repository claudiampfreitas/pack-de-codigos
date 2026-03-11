program fibo;
var qnt,numero,anterior,contador,soma:integer;
begin
write('Informe um numero: ');
read(numero);	
write('Informe a quantidade de numeros que deseja ver da sequencia fibonacci: ');
read(qnt);
contador:=0;
soma:=0;
anterior:=numero-1;
while (contador<qnt) do
begin
write(numero,' ');
soma:=numero+anterior;
anterior:=numero;
numero:=soma;
contador:=contador+1;
readln;
end;
readln;
end.