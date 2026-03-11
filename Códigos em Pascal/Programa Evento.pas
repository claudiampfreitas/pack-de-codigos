Program dados;
var
quantidade_de_participantes,participantes_masculino,participantes_feminino:integer;
maior_40,soma_idade,i,idade:integer;
media_idade:real;
sexo:char;
Begin
i:=1;
Writeln('Qual a idade do participante? 0=fim ');
Readln(idade);
While (idade <> 0) do
Begin
Write('Escreva o sexo do participante [M/F]: ');
Readln(sexo);
If (sexo = 'm') or (sexo = 'M') then participantes_masculino:=participantes_masculino+1;
If (sexo = 'f') or (sexo = 'F') then
participantes_feminino:=participantes_feminino+1;
If (idade>40) then
maior_40:=maior_40+1;
soma_idade:=soma_idade+idade;
i:=i + 1;
quantidade_de_participantes:=quantidade_de_participantes+1;
Writeln('Escreva a idade do próximo participante: 0=fim ');
Readln(idade);
End;
media_idade:=soma_idade/quantidade_de_participantes;
writeln;
Writeln('Total de participantes do sexo masculino: ', participantes_masculino);
Writeln('Total de participantes do sexo feminino: ', participantes_feminino);
Writeln('Total de participantes com mais de 40 anos: ', maior_40);
Writeln('Média geral das idades: ', media_idade);
readln;
End.