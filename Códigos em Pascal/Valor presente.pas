Program valor_presente;
var valfut,valpres,juros,i:real;
var n:integer;
Begin
writeln('Qual o valor futuro?');
readln(valfut);
writeln('Qual a taxa em meses?');
readln(i);
i:=i/100;
writeln('Qual o periodo?');
writeln('Se for em anos, converta para meses');
readln(n);
juros:=exp(ln(1+i)*n);
valpres:=valfut/juros;
writeln('O valor presente é de = ',valpres:0:2);
readln;  
End.