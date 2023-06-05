using NUnit.Framework;
using Mindbox.ShapeSquares.Shapes;

namespace Mindbox.ShapeSquares.Test;

[TestFixture]
public class Tests
{
    [Test]
    public void CircleTest1()
    {
        const double radius = 10d;
        var circle = new Circle(radius);
        
        Assert.That(circle.Square, Is.EqualTo(Math.PI * Math.Pow(radius, 2)));
    }
    
    [Test]
    public void CircleTest2()
    {
        const double radius = 20d;
        var circle = new Circle
        {
            Radius = radius
        };

        Assert.That(circle.Square, Is.EqualTo(Math.PI * Math.Pow(radius, 2)));
    }
        
    [Test]
    public void CircleTest3()
    {
        var radius = new Random().NextDouble();
        var circle = new Circle(radius);
        
        Assert.That(circle.Square, Is.EqualTo(Math.PI * Math.Pow(radius, 2)));
    }
    
    [Test]
    public void CircleTest4()
    {
        const double radius = double.MaxValue;
        var circle = new Circle(radius);
        
        Assert.That(circle.Square, Is.EqualTo(Math.PI * Math.Pow(radius, 2)));
    }
    
    [Test]
    public void CircleTest5()
    {
        var circle = new Circle();
        
        Assert.That(circle.Square, Is.EqualTo(Math.PI * Math.Pow(default,  2)));
    }
    
    [Test]
    public void CircleTest6()
    {
        const double radius = -10d;
        var circle = new Circle(radius);

        var ex = Assert.Throws<ArgumentException>(() =>
        {
            var _ = circle.Square;
        });

        StringAssert.Contains("The radius must be greater than or equal to zero.", ex?.Message);
    }
}