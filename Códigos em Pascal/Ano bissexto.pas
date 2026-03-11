program ano_bissexto;
var ano:integer;
begin
writeln('Vamos saber se o ano e bissexto');
writeln;
writeln('Forneca o ano');
readln(ano);
if ano mod 4=0 then
writeln('O ano ',ano,'  e bissexto')
else
writeln('O ano ',ano,' nao e bissexto');
readln;
end.