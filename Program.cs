using SOLID;
int radius = 0;

radius = 10;
Circle bigCircle = new Circle(radius);


radius = 5;
Circle smallCircle = new Circle(radius);

Console.WriteLine("Small circle area = {0} M2", Math.Round(smallCircle.CalcArea(), 2));
Console.WriteLine("Big circle area = {0} M2", Math.Round(bigCircle.CalcArea(), 2));
