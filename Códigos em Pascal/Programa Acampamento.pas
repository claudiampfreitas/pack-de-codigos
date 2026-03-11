program pzim;
var
idade:Integer;
totalm:Integer;
totalf:Integer;
totalff:Integer;
sexo:Char;
media_idade:real;
soma:real;
n:integer;

begin
writeln('Digite aqui a idade da pessoa: ');
readln(idade);
while (idade <> 0) do
begin
writeln('Digite o sexo da pessoa: ');
readln(sexo);
if (sexo = 'm') then
begin
totalm:=totalm+1;
if (sexo = 'f') then
totalf:=totalf+1;
if (idade > 40) then
totalff:=totalff+1;
end;
media_idade:=(media_idade+idade);
writeln('Digite a idade da pessoa: ');
readln(idade);
end;
n:=(totalm+totalff);
soma:=totalm+totalf;
media_idade:=media_idade/n;
writeln;
writeln('A media de idade e: ', media_idade:0:2);
writeln('O total de pessoas do sexo masculino e: ',totalm);
writeln('O total do sexo feminino e: ', totalff);
writeln('As pessoas com mais de 40 anos sao: ', n);
readln;
end.