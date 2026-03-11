Program val_comp;
var val_comp,tot_pagar:real;
begin
writeln('Cálculo de desconto nas compras');
writeln;
writeln('Qual o valor da compra?');
readln(val_comp);
tot_pagar:=val_comp;
if (val_comp>=50) and (val_comp<=100) then
tot_pagar:=val_comp*0.98;
if (val_comp>100) and (val_comp<=165) then
tot_pagar:=val_comp*0.95;
if (val_comp>165) and (val_comp<=250) then
tot_pagar:=val_comp*0.91;
if val_comp>250 then
tot_pagar:=val_comp*0.90;
writeln('Compras abaixo de R$50.00 não terão desconto');
writeln;
writeln('O total a pagar é R$ ', tot_pagar:0:2);
readln;
End.