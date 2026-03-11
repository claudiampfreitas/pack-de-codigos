Program program_calculox;
var n1,raiz,multi:real;
Begin
textcolor(cyan);
writeln('Digite o valor que deseja');
readln(n1);
writeln;
if n1>0 then
begin
raiz:=sqrt(n1);
writeln('O resultado da raiz de ',n1:0:1,' foi ',raiz:0:1);
multi:=n1*3;
writeln('O resultado de ',n1:0:1,' multiplicado por 3 é = ',multi:0:1);
end;
if n1=0 then
writeln('O resultado do cálculo será sempre o mesmo número que você digitou');
if n1<0 then
writeln('Você não digitou um número positivo. O programa será encerrado!!'); 
readln; 
End.