program maior_menor;
var maior,menor:real;
v1,v2:real;
begin
write('Digite um numero: ');
read(v1);
maior:=v1;
menor:=v1;
write('Digite outro numero: ');
read(v2);
if(v2>maior) then
maior:=v2;
if(v2<menor) then
menor:=v2;
writeln('O maior numero digitado foi: ',maior:0:2);
writeln('O menor numero digitado foi: ',menor:0:2);
readln;
end.