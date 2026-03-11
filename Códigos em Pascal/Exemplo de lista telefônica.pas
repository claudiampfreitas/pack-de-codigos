program Lista_telefonica;
var nome_pessoa,telefone:string;
DDD:integer;
resp:char;
begin
writeln('Lista telefonica');
writeln;
repeat
writeln('Digite o nome do contato');
readln(nome_pessoa);
Writeln('Digite o DDD');
readln(DDD);
writeln('Digite o numero de telefone');
readln(telefone);
writeln('Deseja inserir um novo contato?');
readln(resp);
until resp='n';
writeln('Encerra a agenda!!!');
readln;
end.