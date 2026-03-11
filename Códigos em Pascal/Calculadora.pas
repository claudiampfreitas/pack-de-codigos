program Calculadora;
var a,b,c:integer;
resp:char;
begin
writeln('Calculadora');
writeln;
writeln;
repeat
writeln('Informe os valores a serem somados');
readln(a,b);
c:=a+b;
writeln('soma: ', c);
writeln;
writeln('Deseja fazer uma nova soma?');
readln(resp);
until resp='n';
writeln('Acabou o programa!!!');
readln;
end.