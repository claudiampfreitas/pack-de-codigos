program idade;
var quant_pessoas,idade,maior_idade:integer;
begin
for quant_pessoas:=1 to 10 do
begin
writeln('Informe a idade: ');
readln(idade);
if (idade>18) then
maior_idade:=maior_idade+1;
end;
writeln;
writeln('A quantidade de pessoas com idade maior que 18 anos: ',maior_idade);
readln;
end.