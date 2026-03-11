Program numeros;
var
vet:array[1..5] of integer;
somaTotal,cont,somaImpar,somaPar:integer;
Begin
somaTotal:=0;
somaImpar:=0;
somaPar:=0;
for cont:=1 to 5 do
begin
writeln('Digite o ',cont, 'º numero: ');
readln(vet[cont]);
end;
for cont:=1 to 5 do
begin
if (vet[cont] mod 2=1) then
begin
somaImpar:=somaImpar+vet[cont];
end
else
begin
somaPar:=somaPar+vet[cont];
end;
end;
somaTotal:=somaImpar+somaPar;
writeln;
writeln('A soma dos numeros impares:  ', somaImpar);
writeln('A soma dos numeros pares:  ', somaPar);
writeln('A soma de todos os numeros: ', somaTotal);
readln;  
End.