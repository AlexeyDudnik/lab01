using System;
class MyRectangle
{
    private double SideA;
    private double SideB;
    public Rectangle(double sideA, double sideB)
    {
        this.SideA = sideA;
        this.SideB = sideB;
    }
    private double CalcArea()
    {
        return SideA * SideB;
    }
    private double CalcPerimetr()
    {
        return 2*(SideB + SideA);
    }
    public double Area
    {
        get { return CalcArea(); }
    }
    public double Perimetr
    {
        get { return CalcPerimetr(); }
    }
}
class Progr
{
    static void Main()
    {
        double SideA = double.Parse(Console.ReadLine());
        double SideB = double.Parse(Console.ReadLine());
        Rectangle rectangle = new MyRectangle(SideA, SideB);
        Console.WriteLine(rectangle.Area);
        Console.WriteLine(rectangle.Perimetr);
    }
}
