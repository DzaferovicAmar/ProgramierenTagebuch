using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;

namespace Shapes;
public class Triangle : Shape
{
    public Triangle(Point point) : base(point) 
    {
        
    }
    public override bool DrawSelf()
    {
        throw new NotImplementedException();
    }
}