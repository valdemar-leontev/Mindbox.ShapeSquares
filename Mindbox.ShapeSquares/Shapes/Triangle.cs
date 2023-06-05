using Mindbox.ShapeSquares.Contracts;

namespace Mindbox.ShapeSquares.Shapes;

public class Triangle : IShape
{
    private const string ExceptionMessage = "The side must be greater than or equal to zero.";

    private double _sideA;
    
    private double _sideB;
    
    private double _sideC;

    public double SideA
    {
        get => _sideA;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(ExceptionMessage);
            }

            _sideA = value;
        }
    }

    public double SideB {
        get => _sideB;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(ExceptionMessage);
            }

            _sideB = value;
        }
    }
    
    public double SideC {
        get => _sideC;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(ExceptionMessage);
            }

            _sideC = value;
        }
    }
    
    public Triangle(double a, double b, double c)
    {
        SideA = a;
        SideB = b;
        SideC = c;
    }
    
    public Triangle()
    {
        SideA = default;
        SideB = default;
        SideC = default;
    }
    
    public double Square
    {
        get
        {
            var perimeter = SideA + SideB + SideC;

            return Math.Sqrt(
                perimeter *
                (perimeter - SideA) *
                (perimeter - SideB) *
                (perimeter - SideC)
            );
        }
    }

    public bool IsRightTriangle
    {
        get
        {
            var sidesArray = new[] { SideA, SideB, SideC };
            var maxSide = sidesArray.Max();
            return Math.Abs(sidesArray.Except(new[] { maxSide })
                .Sum(x => x * x) - maxSide * maxSide) < double.Epsilon;
        }
    }
}