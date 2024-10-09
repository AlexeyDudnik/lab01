using System;
using System.Reflection.Metadata;

public class Point
{
    private double X;
    private double Y;
    public Point(double X, double Y)
    {
        this.X = X;
        this.Y = Y;
    }
    public double PointX
    {
        get { return X; }
    }
    public double PointY
    {
        get { return Y; }
    }
}
class Figure
{
    private Point[] points;
    public string Name {get;set;}
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
        if (p5 == null)
        {
            Name = "треугольник";
        }
        else if (p4 == null)
        {
            Name = "четырехугольник";
        }
        else
        {
            Name = "пятиугольник";
        }
    }
    public Figure(Point p1, Point p2, Point p3) : this(p1, p2, p3, null, null)
    {
        Name = "треугольник";
    }
    public Figure(Point p1, Point p2, Point p3,Point p4) : this(p1, p2, p3, p4, null)
    {
        Name = "четырехугольник";
    }
    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.PointX - A.PointX, 2) + Math.Pow(B.PointY - A.PointY, 2));
    }
    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            if (points[i] != null && points[i + 1] != null)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
        }
        if (points[0] != null && points[points.Length - 1] != null)
        {
            perimeter += LengthSide(points[points.Length - 1], points[0]);
        }
        return perimeter;
    }
}
class Progr
{
    static void Main()
    {
        Point p1 = new Point(1, 1);
        Point p2 = new Point(2, 2);
        Point p3 = new Point(3, 3);
        Figure triangle = new Figure(p1, p2, p3);
        Console.WriteLine(triangle.Name);
        Console.WriteLine(triangle.PerimeterCalculator());
    }
}
