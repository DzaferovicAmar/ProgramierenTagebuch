using Avalonia;

namespace Shapes;

public abstract class Shape
{
    public Point Point { get; }
    private static int _idCounter;
    public int Id { get; }
    public Shape(Point point) 
    {
        Id = _idCounter++;
        Point = point;
    }
    public abstract bool DrawSelf();
}