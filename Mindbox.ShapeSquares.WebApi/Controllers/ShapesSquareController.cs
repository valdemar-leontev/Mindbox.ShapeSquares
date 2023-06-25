using Microsoft.AspNetCore.Mvc;
using Mindbox.ShapeSquares.Shapes;

namespace Mindbox.ShapeSquares.WebApi.Controllers;

[ApiController]
[Route("/shape-squares")]
public class ShapeSquaresController : ControllerBase
{

    private readonly Triangle _triangle;
    private readonly Circle _circle;

    public ShapeSquaresController(Triangle triangle, Circle circle)
    {
        _triangle = triangle;
        _circle = circle;
    }
    
    [HttpGet("/circle")]
    public IActionResult GetCircleSquare(double radius)
    {
        _circle.Radius = radius;
        
        return Ok(_circle.Square);
    }

    [HttpGet("/triangle")]
    public IActionResult GetTriangleSquare(double aSide, double bSide, double cSide)
    {
        _triangle.SideA = aSide;
        _triangle.SideB = bSide;
        _triangle.SideC = cSide;

        return Ok(_triangle.Square);
    }

    [HttpGet("/triangle/isRight")]
    public IActionResult GetTriangleIsRight(double aSide, double bSide, double cSide)
    {
       _triangle.SideA = aSide;
       _triangle.SideB = bSide;
       _triangle.SideC = cSide;

       return Ok(_triangle.IsRightTriangle);
    }
}