using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleXPlatDrawing;
using Avalonia.Media;
using Avalonia;

namespace Shapes;
public class Rectangle : Shape
{
    public Rectangle(Point point) : base(point)
    {

    }
    
    public override bool DrawSelf()
    {
        Point point1 = new Point(Point.X - 10, Point.Y - 10);
        Point point2 = new Point(Point.X + 10, Point.Y + 10);
        SimpleDrawing.DrawRectangle(point1, point2, fillColor: Brushes.Red);
        return true;
    }
}