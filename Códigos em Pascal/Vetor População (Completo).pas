program cidadesmg;
uses crt;
var cid:array [2..853] of string;
pop:array [2..853] of integer;
pop_maior,pop_n,I:integer;
cid_maior,cid_nome:string;
begin
 pop_maior:=0;
 	For i:=2 to 853 do
	begin
	writeln('Qual nome da cidade?');
	readln(cid[I]);
	cid_nome:=cid[I];
	writeln('Qual a população dessa cidade?');
	readln(pop[I]);
	pop_n:=pop[I];
	if pop_n>pop_maior then
	begin
	cid_maior:=cid_nome;
	pop_maior:=pop_n;
	end;
	end;
	Writeln('A cidade com maior população é ',cid_maior,' com população de ',pop_maior,' habitantes.');
	readln;
end.