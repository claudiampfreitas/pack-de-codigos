Program ExemploPzim ;
Var N, i: integer;
    isPrimo: boolean;
    respostaUsuario: char;	
 Begin 	
 	repeat 
 	   // Solicita um número 
	   write('Informe um número: ');
	   readln(N);
	   writeln;
	   
	   // Tenta dividir esse número por 2, 3, ..., N-1
	   // Até que se prove o contrário, nosso número é primo! 
	   i:=2;
	   isPrimo:= true ;
   	   while (i<N) and (isPrimo) do  
		begin
			if (N mod i = 0) then 
			  begin     
				isPrimo:= false ;
			  end ; 	
		     i:= i+1 ;
		end;
	     	
		if (isPrimo) then 
		  Begin
			writeln(N, ' é um número primo');
		  End 
		else 
		  Begin
			writeln(N, ' não é um número primo, porque é divisível por ', i-1);
	 	  End;
		
		// Solicita resposta do usuário, para pedir outro número
		writeln;
		write('Deseja continuar? (S/N)');		
		readln(respostaUsuario);
		writeln;
		
	until (respostaUsuario='N') or (respostaUsuario='n') ;
	readln;
 End.
 

