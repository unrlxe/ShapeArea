namespace ShapeArea.Tests;

public class CircleTests
{
    [Fact]
    public void CreateCircleInstance_NegativeValueException_WhenSideValuesInvalid()
    {
        Assert.Throws<NonPositiveValueException>(() =>
        {
            var circle = new Circle(-1);
        });
    }

    [Fact]
    public void SetTriangleSide_ThrowsNegativeValueException_WhenSideValuesInvalid()
    {
        Assert.Throws<NonPositiveValueException>(() =>
        {
            var circle = new Circle(1);
            circle.Radius = -1;
        });
    }

    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, 4 * Math.PI)]
    [InlineData(2.3, 5.29 * Math.PI)]
    [InlineData(1.2, 1.44 * Math.PI)]
    public void GetTriangleArea(double r, double expectedArea)
    {
        var circle = new Circle(r);

        Assert.True(Math.Abs(expectedArea - circle.Area) < 1e-6);
    }
}