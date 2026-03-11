Program juros_simples;
var valfut,valpres,i:real;
var n:integer;
Begin
writeln('Qual o valor presente?');
readln(valpres);
writeln('Qual a taxa?');
readln(i);
writeln('Qual o periodo?');
readln(n);
valfut:=valpres*(1+i*n);
writeln('O valor futuro e de = ',valfut:0:2);
readln;  
End.