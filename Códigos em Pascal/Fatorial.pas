Program ExemploPzim ;
var fatorial: integer ;
    i: integer ;
    N: Integer;    
 Begin 
     // Solicita o valor de N
	write('Informe o Valor de N: ');
	readln(N);
	
	// Calcula o fatorial
	fatorial:= 1;
	for i:= 1 to N do
	  begin
	    	fatorial:= fatorial * i;
       end;
       
     // Mostra resultado  
     write('O Valor de ', N, ' Fatorial é: ', fatorial);
     readln;
 End.
 

