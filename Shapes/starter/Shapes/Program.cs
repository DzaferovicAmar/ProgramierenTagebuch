using System.Linq.Expressions;
using System.Text;
using Avalonia;
using Shapes;
using SimpleXPlatDrawing;

Console.OutputEncoding = Encoding.UTF8;

const int Size = 600;

var shapes = new List<Shape>();
var generator = new ShapeGenerator(Size, Size);

SimpleDrawing.Init(Size, Size, HandleClick, "Shapes");

// initial rendering
await Redraw();

Console.WriteLine("Press any key to exit...");
Console.ReadKey();


async void HandleClick(Point pointClicked)
{
    // TODO - handle click at location
    shapes.Add(generator.CreateNewShape(pointClicked));
    await Redraw();
}

async Task Redraw()
{
    SimpleDrawing.Clear();
    foreach (var shape in shapes)
    {
        if (!shape.DrawSelf())
        {
            Console.WriteLine($"Couldn't draw shape with id {shape.Id} 😭");
        }
    }
    await SimpleDrawing.Render();
}