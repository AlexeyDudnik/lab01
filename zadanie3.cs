using System;
public class Point
{
    private int x;
    private int y;
    public int X { get { return x; } }
    public int Y { get { return y; } }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}
public class Figure
{
    private Point[] points;
    public string Name { get; set; }
    public Figure(Point p1, Point p2, Point p3) : this(p1, p2, p3, null, null) { }
    public Figure(Point p1, Point p2, Point p3, Point p4) : this(p1, p2, p3, p4, null) { }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
        Name = "Многоугольник";
    }
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
    public double PerimeterCalculator()
    {
        double perimeter = 0;
        int validPointsCount = 0;
        foreach (var point in points)
        {
            if (point != null)
            {
                validPointsCount++;
            }
        }
        for (int i = 0; i < validPointsCount - 1; i++)
        {
            perimeter += LengthSide(points[i], points[i + 1]);
        }
        perimeter += LengthSide(points[validPointsCount - 1], points[0]);

        return perimeter;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(0, 0);
        Point p2 = new Point(4, 0);
        Point p3 = new Point(4, 3);
        Figure triangle = new Figure(p1, p2, p3);
        triangle.Name = "Треугольник";
        Console.WriteLine($"Название фигуры: {triangle.Name}");
        Console.WriteLine($"Периметр фигуры: {triangle.PerimeterCalculator()}");
    }
}
