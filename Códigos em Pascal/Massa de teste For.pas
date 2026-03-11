program pzim;
var x,soma,y:integer;
begin
soma:=0;
for x:=1 to 10 do
begin
y:=(x*x);
writeln(y);
end;
writeln;
for x:=1 to 10 do
begin
soma:=soma+(x*x);
writeln(soma);
end;
readln;
end.