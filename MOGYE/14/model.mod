var x1 >= 0;
var x2 >= 0;
var x3 >= 0;
var x4 >= 0;

s.t. st1: 2 * x1 + 6 * x2 + x3 + x4 <= 30;
s.t. st2: x1 + 2 * x2 + x3 = 10;
s.t. st3: -x1 + x2 - x3 + x4 >= 4;

maximize ered: x1 + 2 * x2 - 13 * x3 + 4 * x4;