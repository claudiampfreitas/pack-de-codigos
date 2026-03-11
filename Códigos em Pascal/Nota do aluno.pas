program nota;
var nota:real;
begin
writeln('Digite a nota obtida');
readln(nota);
if (nota>=0) and (nota<=4) then
writeln('Aluno regular');
if (nota>=5) and (nota<=7) then
writeln('Aluno bom');
if (nota>=8) and (nota<=10) then
writeln('Aluno otimo');
readln;
end.