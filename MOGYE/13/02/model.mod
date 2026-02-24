set Sandwich;
set Parts;

param PartCount{Parts, Sandwich};
param MaxParts{Parts};

var x{Sandwich};

s.t. pMax{p in Parts}: sum{s in Sandwich} x[s] * PartCount[p, s] <= MaxParts[p];

maximize darab: sum{s in Sandwich} x[s];

data;

set Sandwich := szalamis sonkas;
set Parts := vaj tojas szalami sonka;

param PartCount: szalamis sonkas :=
		vaj 3 4
		tojas 3 2
		szalami 2 0
		sonka 0 1;

param MaxParts := vaj 220 tojas 170 szalami 100 sonka 40;

end;