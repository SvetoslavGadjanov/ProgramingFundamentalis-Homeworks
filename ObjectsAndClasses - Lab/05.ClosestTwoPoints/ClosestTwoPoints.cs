using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ClosestTwoPoints
{
    static void Main(string[] args)
    {
        var points = Point.ReadArrayOfPoints();

        var nearestPoints = FindNearestPoints(points);

        Console.WriteLine("{0:f3}", Point.CalcDistance(nearestPoints[0], nearestPoints[1]));
        Console.WriteLine(nearestPoints[0]);
        Console.WriteLine(nearestPoints[1]);
    }

    static Point[] FindNearestPoints(Point[] points)
    {
        var minDistance = double.MaxValue;
        var nearestPoints = new Point[] { };

        for (int first = 0; first < points.Length; first++)
        {
            for (int second = first+1; second < points.Length; second++)
            {
                var p1 = points[first];
                var p2 = points[second];
                var distance = Point.CalcDistance(p1, p2);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    nearestPoints = new Point[] { p1, p2 };
                }
            }
        }
        return nearestPoints;
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

