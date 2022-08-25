int FindQuadrant ( double x, double y){
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

Console.Write("Input X coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input Y coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());

int quadrant = FindQuadrant(xA, yA);
if (quadrant > 0)
    Console.WriteLine($"Num of quad is {quadrant}");
else
    Console.WriteLine($"The point is on the axes");