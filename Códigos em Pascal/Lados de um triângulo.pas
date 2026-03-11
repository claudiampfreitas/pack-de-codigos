Program Pzim ;
var l1,l2,l3:integer;
Begin
writeln('Qual o primeiro lado?');
readln(l1);
writeln('Qual o segundo lado?');
readln(l2);
writeln('Qual o terceiro lado?');
readln(l3);
if (l1+l2>l3) and (l3+l2>l1) and (l3+l1>l2) then
begin
if (l1=l2) and (l1=l3) then
writeln('É um triângulo equilátero')
else
if (l1=l2) or (l2=l3) or (l1=l3) then
writeln('É um triângulo isósceles')
else
writeln('É um triângulo escaleno')
end
else
writeln('Os valores não formam um triângulo');
readln;
End.