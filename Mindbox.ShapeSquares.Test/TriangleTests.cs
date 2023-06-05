using Mindbox.ShapeSquares.Shapes;
using NUnit.Framework;

namespace Mindbox.ShapeSquares.Test;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void TriangleTest1()
    {
        const double sideA = 10d;
        const double sideB = 20d;
        const double sideC = 30d;
        
        var triangle = new Triangle(sideA, sideB, sideC);
        
        var perimeter = sideA + sideB + sideC;
        var expectedValue =  Math.Sqrt(
            perimeter *
            (perimeter - sideA) *
            (perimeter - sideB) *
            (perimeter - sideC)
        );

        Assert.That(triangle.Square, Is.EqualTo(expectedValue));
    }
    
    [Test]
    public void TriangleTest2()
    {
        var random = new Random();
        
        var sideA = random.NextDouble();
        var sideB = random.NextDouble();
        var sideC = random.NextDouble();
        
        var triangle = new Triangle(sideA, sideB, sideC);
        
        var perimeter = sideA + sideB + sideC;
        var expectedValue =  Math.Sqrt(
            perimeter *
            (perimeter - sideA) *
            (perimeter - sideB) *
            (perimeter - sideC)
        );

        Assert.That(triangle.Square, Is.EqualTo(expectedValue));
    }
    
    [Test]
    public void TriangleTest3()
    {
        var triangle = new Triangle
        {
            SideA = 10d,
            SideB = 11d,
            SideC = 12d
        };

        Assert.IsFalse(triangle.IsRightTriangle);
    }
    
    [Test]
    public void TriangleTest4()
    {
        var sideA = 3d;
        var sideB = 5d;
        var sideC = 4d;
        
        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.IsTrue(triangle.IsRightTriangle);
    }
    
    [Test]
    public void TriangleTest5()
    {
        var sideA = 31d;
        var sideB = 1d;
        var sideC = 2d;
        
        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.IsFalse(triangle.IsRightTriangle);
    }
}