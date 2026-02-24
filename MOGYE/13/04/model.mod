set Products;
set Machine;

param Cost{Products};
param MaterialCost{Products};
param MaxHour{Machine};
param MachineHour{Machine, Products};

param MinCost;

var x{Products} >= 0 integer;

s.t. mh{m in Machine}: sum{p in Products} x[p] * MachineHour[m, p] <= MaxHour[m];
s.t. mincost: sum{p in Products} x[p] * Cost[p] >= MinCost;

minimize matcost: sum{p in Products} x[p] * MaterialCost[p];

data;

set Products := t1 t2 t3;
set Machine := g1 g2;

param Cost := t1 3 t2 1 t3 2;
param MaterialCost := t1 0.8 t2 0.2 t3 0.5;
param MaxHour := g1 80 g2 70;
param MachineHour: t1 t2 t3 :=
		g1 2 1 1
		g2 1 1 1;

param MinCost := 100;

end;