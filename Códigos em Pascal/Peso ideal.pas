Program peso_ideal;
var peso,altura:real;
sexo:string;
Begin
writeln('Calculo do peso ideal');
writeln;
writeln('Qual a altura?');
readln(altura);
writeln('Qual o sexo?');
readln(sexo);
if sexo='feminino' then
peso:=(62.1*altura)-44.7;
if sexo='masculino' then
peso:=(72.7*altura)-58;
writeln;
writeln('O peso ideal é ' ,peso:0:2);
readln;
End.