program prog_venda;
var nome_produto:string;
preco_unitario,quantidade_venda,total_venda:real;
begin
writeln('programa de vendas');
writeln;
writeln('qual o nome do produto?');
readln(nome_produto);
writeln('qual o valor unitario?');
readln(preco_unitario);
writeln('qual a quantidade vendida?');
readln(quantidade_venda);
total_venda:=preco_unitario*quantidade_venda;
writeln;
writeln('o total da venda = R$ ',total_venda:0:2);
writeln('so sera aplicado um desconto de 8 por cento para vendas acima de R$500,00');
 if (total_venda>500)then
 begin
 total_venda:=total_venda*0.92;
 writeln('O total da venda com desconto = R$',total_venda:0:2);
 end;
readln;
end.