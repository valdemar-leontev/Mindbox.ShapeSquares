using Microsoft.AspNetCore.Mvc;
using Mindbox.ShapeSquares.Shapes;

namespace Mindbox.ShapeSquares.WebApi;

[ApiController]
[Route("/shape-squares")]
public class ShapeSquaresController : ControllerBase
{
    [HttpGet("/circle")]
    public IActionResult GetCircleSquare(double radius)
    {
        var circle = new Circle(radius);

        var circleSquare = circle.Square;

        return Ok(circleSquare);
    }

    [HttpGet("/triangle")]
    public IActionResult GetTriangleSquare(double aSide, double bSide, double cSide)
    {
        var triangle = new Triangle(aSide, bSide, cSide);

        var triangleSquare = triangle.Square;

        return Ok(triangleSquare);
    }
}