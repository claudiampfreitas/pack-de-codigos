program teste;
var v, cont:integer;
mensagem: string;
begin
  writeln ('Informe a mensagem');
  readln(mensagem);
  writeln ('Quantas vezes deseja repetir?');
  readln(v);
  writeln;
  for cont:=1 to v do
    begin
        writeln(mensagem);
    end;
    readln;
end.