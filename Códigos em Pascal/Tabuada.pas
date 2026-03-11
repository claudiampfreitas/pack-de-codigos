Program ExemploPzim ;
Var i: integer ;
    N: integer;
 Begin
    // Solicita o número
    write('Informe o número desejado: ');
    readln(N);
    writeln;
    
    // Mostra a tabuada do número
    for i:= 1 to 10 do
      begin
        writeln(N, ' X ', i:2, '=', N*i:2);
      end;
      readln;
 End.
