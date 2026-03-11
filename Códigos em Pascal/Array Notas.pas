Program lervetor;
var
 notas:array[1..10] of real;
 total,media:real;
 i:integer;
Begin
total:=0;
for i:= 1 to 10 do
begin
writeln('Qual a nota obtida?');
readln(notas[i]);
total:=total+notas[i];
end;
media:=total/10;
writeln;
writeln('A media da turma foi: ' , media:0:1);
writeln('A quantidade de provas foi: ' , i);
if (notas[i] <= 0) then
writeln('O programa se encerra');
readln;
end.