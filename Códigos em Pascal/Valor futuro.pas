Program valor_futuro;
var valfut,valpres,juros,i:real;
var n:integer;
Begin
writeln('Programa Cálculo do valor futuro');
writeln;
writeln('Qual o valor presente?');
readln(valpres);
writeln('Qual a taxa em meses?');
readln(i);
i:=i/100;
writeln('Qual o periodo?');
writeln('Se for em anos, converta para meses');
readln(n);
juros:=exp(ln(1+i)*n);
valfut:=valpres*juros;
writeln;
writeln('O valor futuro é de = ',valfut:0:2);
readln;  
End.