program Exemplo_Array;
var nota:array [1..10] of real;
indice:integer;
begin
for indice:=1 to 10 do
begin
writeln('Introduza uma nota ', indice, ':');
readln(nota[indice]);
end;
writeln;
writeln('A primeira nota introduzida foi: ', nota[1]:0:2);
writeln('A ultima nota introduzida foi: ', nota[10]:0:2);
readln;
end.