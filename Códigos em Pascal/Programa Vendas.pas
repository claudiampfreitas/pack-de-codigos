program Prog_vendas;
var nome_prod:string;
preco_unit,quant_vend,total_venda:real;
begin
writeln('Programa vendas');
writeln('Qual o nome do peoduto?');
readln(nome_prod);
writeln('Qual o valor unitario?');
readln(preco_unit);
writeln('Qual a quantidade vendida?');
readln(quant_vend);
total_venda:=preco_unit*quant_vend;
writeln('O total da venda = R$',total_venda);
writeln('So sera aplicado um desconto de 0.08 para vendas acima de R$500,00');
 if (total_venda>500) and (nome_prod='camisa social') then
 begin
 total_venda:=total_venda*0.92;
 writeln('O total da venda com desconto = R$',total_venda);
 end;
readln;
end.