using Mindbox.ShapeSquares.Contracts;
using Mindbox.ShapeSquares.Shapes;

namespace Mindbox.ShapeSquares.Consumer;

public static class App
{
    public static void Main()
    {
         var shapes = new IShape[] { new Circle(10), new Triangle(3, 4, 5) };
        
            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.Square);
            }
    }
}