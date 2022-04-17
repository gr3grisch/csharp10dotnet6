using static System.Console;

int a = 10;
double b = a; // an int can be safely cast into a double
WriteLine(b);

double c = 9.8;
// int d = c; // compiler gives an error for this line
// WriteLine(d);

int d = (int)c;
WriteLine(d); // d is 9 losing the .8 part