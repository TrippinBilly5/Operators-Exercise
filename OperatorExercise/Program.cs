int a = 17;
int b = 4;
int sum = a + b;

int c = 21;
int d = 5;
int quotient = c / d;
int remainder = a % b;

Console.WriteLine($"{c}/{d} is {quotient} remainder {remainder}");

Console.WriteLine("input the radius of a circle");
double radius = double.Parse(Console.ReadLine());
double area = AreaOfCircle(radius);
Console.WriteLine($"The area of a circle with radius of {radius} is {area}.");

var i = 3;
var j = 4;
var k = ++i * j++;
Console.WriteLine($"i = {i}, j = {j}, k = {k}");

double AreaOfCircle( double radius)
{
    return Math.PI * Math.Pow(radius, 2);
}
