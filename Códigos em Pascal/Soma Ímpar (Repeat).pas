program SomaImpares;
var impar,soma:integer;
begin
soma:=0;
impar:=1;
repeat
if (impar<15) or (impar>23) then
begin
writeln(impar);
soma:=soma+impar;
end;
impar:=impar+2;
until impar=33;
writeln;
writeln(soma);
readln;
end.