program programa;
var n1,result1,result2:real;
begin
writeln('Digite um numero');
readln(n1);
begin
if n1>0 then
result1:=sqrt(n1);
writeln('O valor da raiz quadrada e ',result1);
result2:=(n1)*3;
writeln('O valor da multiplicacao e ',result2);
readln(result2);
end;
begin
if n1<0 then
writeln('O numero nao possui valor real');
end;
readln;
end.