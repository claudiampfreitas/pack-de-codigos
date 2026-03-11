program nota_aluno;
var nota1,nota2,nota3,result:real;
begin
writeln('Programa nota final');
writeln;
writeln('Qual a nota da etapa 1?');
readln(nota1);
writeln('Qual a nota da etapa 2?');
readln(nota2);
writeln('Qual a nota da etapa 3?');
readln(nota3);
writeln;
result:=nota1+nota2+nota3;
if result>=60 then
writeln('Aluno aprovado. Parabéns!!');
if (result>=25) and (result<60) then
writeln('Aluno em recuperacao');
if result<25 then
writeln('Infelizmente o aluno foi reprovado!!');
writeln('A nota final = ', result);
readln;
end.