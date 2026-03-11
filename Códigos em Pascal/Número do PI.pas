Program Pzim ;
var i,n: integer;
    Pi: real;

Begin
 // Solicita o numero de termos da série
 write('Informe o numero de termos da serie: ');
 read(n);
 
 // Caclula o valor de PI
 Pi:=3;
 For i:=2 to n do
 Begin
   // Os termos na posicao par sao positivos
   if (i mod 2 = 0) then
   	 Pi:= Pi+(1/i);
   // Os termos na posicao impar sao negativos
   if (i mod 2 <> 0) then
      Pi:= Pi-(1/I);
 End;
		write ('Número Pi é igual à ',Pi);
		readln;
End.
