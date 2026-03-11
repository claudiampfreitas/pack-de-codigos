program prog_maior;
var n1,n2,n3:real;
begin
writeln ('Programa número maior');
writeln;
writeln ('Qual o primeiro número?');
readln (n1);
writeln ('Qual o segundo número?');
readln (n2);
writeln ('Qual o terceiro número?');
readln (n3);
writeln;
if (n1>n2) and (n1>n3) then
writeln ('O primeiro número é o maior');
if (n2>n1) and (n2>n3) then
writeln ('O segundo número é o maior');
if (n3>n1) and (n3>n2) then
writeln ('O terceiro número é o maior');
readln;
End.