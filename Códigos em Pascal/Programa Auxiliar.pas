Program auxiliar;
var a,b,c,aux:integer;
begin
writeln('Digite um número');
readln(a);
writeln('Digite mais um número');
readln(b);
writeln('Digite outro número');
readln(c);
if (a>b) or (a>c) then
if b<c then
begin
aux:=a;
a:=b;
b:=aux;
end
else
begin
aux:=a;
a:=c;
c:=aux;
end;
if b>c then
begin
aux:=b;
b:=c;
c:=aux;
end;
writeln;
writeln('Os números ficaram assim:');
writeln(a);
writeln(b);
writeln(c);
readln;
End.
