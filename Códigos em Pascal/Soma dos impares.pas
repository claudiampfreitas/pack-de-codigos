program SomaImpares;
var impar,soma:integer;
begin
soma:=0;
impar:=1;
while impar<33 do
begin
if (impar<15) or (impar>23) then
writeln(impar);
soma:=soma+impar;
impar:=impar+2;
end;
writeln;
writeln(soma);
readln;
end.