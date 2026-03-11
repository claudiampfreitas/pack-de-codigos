program prog_Delta;
var Delta,valA,valB,Valc:Real;
begin
  writeln('Programa calculo do Delta');
  writeln;
   writeln('Forneca o valor de B');
   readln(ValB);
   writeln('Forneca o valor de A');
   readln(valA);
   writeln('Forneca o valor de C');
   readln(valc);
	 Delta:=sqr(ValB)-4*ValA*Valc;
	 writeln;
   writeln('o resultado de delta = ', Delta:0:2); 
   readln;
end.