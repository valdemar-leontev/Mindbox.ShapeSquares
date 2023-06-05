using Mindbox.ShapeSquares.Contracts;

namespace Mindbox.ShapeSquares.Shapes;

public class Circle : IShape
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The radius must be greater than or equal to zero.");
            }

            _radius = value;
        }
    }

    public Circle()
    {
        Radius = default;
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double Square => Math.PI * Math.Pow(Radius, 2);
}