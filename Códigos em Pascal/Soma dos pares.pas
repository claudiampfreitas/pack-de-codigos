Program ExemploPzim ;
 Var i, soma: integer ;  { Declaração de variaveis }
 Begin
   i := 2;       { Inicialização das variaveis }     
   soma := 0 ;

   Repeat                 { Repeticao }
      Soma := soma + i ;
      i:= i + 2 ;
   Until i > 200;         { Fim da Repeticao }

   writeln( 'A soma dos pares de 1 a 200 = ' , soma );
   readln;
 End.

