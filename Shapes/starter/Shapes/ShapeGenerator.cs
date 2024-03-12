using Avalonia;

namespace Shapes;

/// <summary>
///     A random shape generator
/// </summary>
public sealed class ShapeGenerator
{
    private const int MinShapeIdx = 1;
    private const int MaxShapeIdx = 4;
    private readonly double _maxX;
    private readonly double _maxY;
    private readonly Random _random;
    private int _nextShape;

    /// <summary>
    ///     Creates a new generator which will create random shapes within the canvas area
    /// </summary>
    /// <param name="maxX">The max x axis value where shapes may be drawn</param>
    /// <param name="maxY">The max y axis value where shapes may be drawn</param>
    public ShapeGenerator(double maxX, double maxY)
    {
        _maxX = maxX;
        _maxY = maxY;
        _nextShape = MinShapeIdx;
        _random = Random.Shared;
    }

    /// <summary>
    ///     Creates a new random shape at the specified location.
    ///     A circle, rectangle, square or triangle will be created.
    ///     The size of the shape is randomly chosen, but will not exceed the max. drawing
    ///     boundaries - except for at most 5 pixels to allow rendering in any case.
    ///     Shapes may overlap each other.
    /// </summary>
    /// <param name="atLocation">Location of the center point of the new shape</param>
    /// <returns>The newly created shape</returns>
    public Shape CreateNewShape(Point atLocation)
    {
        int shape = _nextShape++;
        if (_nextShape > MaxShapeIdx)
        {
            _nextShape = MinShapeIdx;
        }

        // TODO

        return new Rectangle(atLocation);
    }

    // TODO
}
