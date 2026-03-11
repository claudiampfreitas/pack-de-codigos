program programa;
var n1,result1,result2:real;
begin
writeln('Digite um numero');
readln(n1);
if n1>0 then
Begin
result1:=sqrt(n1);
writeln;
writeln('O valor da raiz quadrada e ',result1:0:1);
result2:=n1*3;
writeln('O valor da multiplicacao e ',result2:0:1);
End
Else
writeln('O numero nao possui valor real');
readln;
end.