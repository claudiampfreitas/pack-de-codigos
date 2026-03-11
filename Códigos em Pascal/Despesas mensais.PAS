program calculo_mensal;
var saldo_final,salario,conta_copasa,credicard,conta_cemig:real;
var deposito:integer;
const conta_oi:real=79.64;
const conta_internet:real=149.82;
const conta_iptu:real=34.62;
begin
writeln('Qual e o salario recebido?');
readln(salario);
writeln('Qual o valor da conta de agua?');
readln(conta_copasa);
writeln('Qual o valor da fatura do cartao de credito?');
readln(credicard);
writeln('Qual o valor da conta de luz?');
readln(conta_cemig);
writeln('Qual o valor do deposito?');
readln(deposito);
writeln('Qual o valor da conta da oi? ', conta_oi:0:2);
writeln('Qual o valor da conta da internet? ', conta_internet:0:2);
writeln('Qual o valor da conta do IPTU? ', conta_iptu:0:2);
saldo_final:=(salario-conta_copasa-credicard-conta_cemig-conta_oi-conta_internet-deposito-conta_iptu);
writeln;
writeln('O valor do saldo final foi de ', saldo_final:0:2);
readln;
end.