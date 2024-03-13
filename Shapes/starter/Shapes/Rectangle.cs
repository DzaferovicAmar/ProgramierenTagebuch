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
        Random randomHeigth = new Random();
        Random randomWidth = new Random();
        int width = randomHeigth.Next(0, 100);
        int randomWidth.Next(0, 100);
        Point point1 = new Point(Point.X - 100, Point.Y - 100);
        Point point2 = new Point(Point.X + 100, Point.Y + 100);
        SimpleDrawing.DrawRectangle(point1, point2, fillColor: Brushes.Red);
        return true;
    }
}