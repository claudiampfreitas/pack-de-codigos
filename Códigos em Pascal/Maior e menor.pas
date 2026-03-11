program maior_menor;
var maior,menor:real;
v1,v2,v3:real;
begin
write('Digite um numero: ');
read(v1);
maior:=v1;
menor:=v1;
write('Digite outro numero: ');
read(v2);
maior:=v2;
menor:=v2;
write('Digite outro numero: ');
read(v3);
maior:=v3;
menor:=v3;
if(v1>maior) then
maior:=v1;
if(v1<menor) then
menor:=v1;
if(v2>maior) then
maior:=v2;
if(v2<menor) then
menor:=v2;
if(v3>maior) then
maior:=v3;
if(v3<menor) then
menor:=v3;
writeln;
writeln('O maior numero digitado foi: ',maior:0:2);
writeln('O menor numero digitado foi: ',menor:0:2);
readln;
end.