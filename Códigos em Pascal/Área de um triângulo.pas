program area_triangulo;
var area:real;
altura:real;
base:real;
begin
writeln('Esse programa calcula a area de um triangulo bastando somente inserir os valores');
writeln;
write('Digite a altura de um triangulo (m): ');
read(altura);
write('Digite o tamanho da base de um triangulo (m): ');
read(base);
area:=(base*altura)/2;
write('A area de um triangulo e (m²): ',area:0:2);
readln;
end.