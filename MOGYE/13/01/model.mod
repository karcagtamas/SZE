var szalamis >= 0 integer;
var sonkas >= 0 integer;

s.t. vaj: szalamis * 3 + sonkas * 4 <= 220;
s.t. tojas: szalamis * 3 + sonkas * 2 <= 170;
s.t. szalami: szalamis * 2 <= 100;
s.t. sonka: sonkas <= 40;

maximize db: szalamis + sonkas;

end;