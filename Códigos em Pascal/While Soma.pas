program SomaImpares;
var i,soma:integer;
begin
for i:=1 to 31 do
if (i mod 2=1) then
writeln(i);
writeln;
i:=1;
soma:=0;
while (i<=31) do
begin
if (i mod 2=1) then
soma:=soma+i;
inc(i);
end;
writeln(soma);
readln;
end.