using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class RectanglePosition
{
    static void Main(string[] args)
    {
        var r1 = Rectangle.ReadRectangle();
        var r2 = Rectangle.ReadRectangle();

        if (Rectangle.IsFirstRectInsideSecondRect(r1, r2))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not Inside");
        }
    }
}

class Rectangle
{
    public double Top { get; set; }
    public double Left { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public double Botom
    {
        get
        {
            return this.Top + this.Height;
        }
    }
    public double Right
    {
        get
        {
            return this.Left + this.Width;
        }
    }

    public static Rectangle ReadRectangle()
    {
        var tokens = Console.ReadLine().Split(' ').Select(Double.Parse).ToArray();
        var rect = new Rectangle()
        {
            Top = tokens[1],
            Left = tokens[0],
            Width = tokens[2],
            Height = tokens[3]
        };
        return rect;
    }
    public override string ToString()
    {
        return String.Format("Rect[Top={0}, Left={1}, Botom={2}, Right={3}]", this.Top, this.Left, this.Botom, this.Right);
    }

    public static bool IsFirstRectInsideSecondRect(Rectangle r1, Rectangle r2)
    {
        var inside =
            r1.Left >= r2.Left &&
            r1.Right <= r2.Right &&
            r1.Top >= r2.Top &&
            r1.Botom <= r2.Botom;
        return inside;
    }

}

