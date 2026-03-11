program CONTGRAO;
var i:Integer;
contgraos,somagraos:real;
begin
contgraos:=1;
somagraos:=1;
for i:=2 to 64 do
begin
contgraos:=contgraos*2;
somagraos:=somagraos+contgraos;
end;
WriteLn(somagraos);
end.