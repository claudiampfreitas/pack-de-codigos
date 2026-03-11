program calc_venda;
var venda,novo_valor:real;
begin
writeln('calcule o valor da venda apos o desconto');
writeln;
writeln('digite o valor da venda');
readln(venda);
novo_valor:=venda*0.90;
writeln('o novo valor da venda com o desconto e de ', novo_valor:0:2);
readln;
end.