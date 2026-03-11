Program Exemplo_Vetor;
var
vet:array[1..5] of integer;
total,cont:integer;
Begin
total:=0;
for cont:=1 to 5 do
begin
writeln('Digite o ',cont, 'º numero:');
readln(vet[cont]);
total:=total+vet[cont];
end;
writeln;
writeln('Total da soma: ', total);
readln;  
End.