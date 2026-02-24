var t1 >= 0 integer;
var t2 >= 0 integer;
var t3 >= 0 integer;

s.t. g1: t1 * 2 + t2 * 1 + t3 * 1 <= 80;
s.t. g2: t1 * 1 + t2 * 1 + t3 * 1 <= 70;
s.t. invoice: t1 * 3 + t2 * 1 + t3 * 2 >= 100;

minimize anyagkolt: t1 * 0.8 + t2 * 0.2 + t3 * 0.5;