namespace ShapeArea.Tests;

public class ShapeTests
{
    [Fact]
    public void GetShapeArea()
    {
        for (var i = 0; i < 1000; i++)
        {
            var shapeType = Random.Shared.Next(1);
            // radius value if circle
            var r = Random.Shared.Next(1, 10);
            // side values if triangle
            var a = Random.Shared.Next(1, 10);
            var b = Random.Shared.Next(1, a);
            var c = Random.Shared.Next(1, b);
            // random shape
            Shape shape = shapeType == 0 ? new Circle(r) : new Triangle(a, b, c);
            var p = (a + b + c) / 2;
            var area = shapeType == 0 ? Math.PI * r * r : Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Assert.True(Math.Abs(area - shape.Area) < 1e-6);
        }
    }
}