using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DistanceBetweenPoints
{
    static void Main(string[] args)
    {
        Point p1 = Point.ReadPiont();
        Point p2 = Point.ReadPiont();

        Console.WriteLine("{0:f3}",Point.CalcDistance(p1, p2));

    }
}

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
}
 
