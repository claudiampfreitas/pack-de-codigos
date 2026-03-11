program prog_area;
const pi=3.14;
var area,raio:real;
begin
writeln('programa calculo da area');
writeln;
writeln('digite o valor do raio');
readln(raio);
area:=pi*sqr (raio);
writeln('o valor da area = ',area);
readln;
end.