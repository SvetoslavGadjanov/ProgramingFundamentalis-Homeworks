using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    public static double CalcDistance(Point p1, Point p2)
    {
        var a = p1.X - p2.X;
        var b = p1.Y - p2.Y;
        var sum = a * a + b * b;
        var distance = Math.Sqrt(sum);
        return distance;
    }
    public static Point ReadPiont()
    {
        var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var p = new Point() { X = coords[0], Y = coords[1] };
        return p;
    }
    public override string ToString()
    {
        return String.Format("({0}, {1})", this.X, this.Y);
    }
    public static Point[] ReadArrayOfPoints()
    {
        int n = Int32.Parse(Console.ReadLine());
        var points = new Point[n];
        for (int i = 0; i < n; i++)
        {
            points[i] = Point.ReadPiont();
        }
        return points;
    }
}

class Circle
{
    public Point Center { get; set; }
    public double Radius { get; set; }

    public static Circle ReadCircle()
    {
        var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Point center = new Point() { X = coords[0], Y = coords[1] };
        double radius = coords[2];
        Circle c = new Circle() { Center = center, Radius = radius };
        return c;
    }
}
class IntersectionOfCircles
{
    static void Main(string[] args)
    {
        Circle firstCircle = Circle.ReadCircle();
        Circle secondCircle = Circle.ReadCircle();

        double distance = Point.CalcDistance(firstCircle.Center, secondCircle.Center);

        if (distance > firstCircle.Radius + secondCircle.Radius)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }



    }
}


