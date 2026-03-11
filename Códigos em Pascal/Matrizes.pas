program matriz;
var mat:array [1..5,1..5] of integer;
i,x,j:integer;
begin
x:=11;
for i:=1 to 5 do
for j:=1 to 5 do
begin
mat[i,j]:=x;
x:=x+2;
end;
for i:=1 to 5 do
for j:=1 to 5 do
write(mat[i,j], ' ');
readln;
end.
