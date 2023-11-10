namespace ShapeArea.Tests;

public class TriangleTests
{
    [Fact]
    public void CreateTriangleInstance_ThrowsInvalidTriangleSideValue_WhenSideValuesInvalid()
    {
        Assert.Throws<InvalidTriangleSideException>(() =>
        {
            var triangle = new Triangle(1, 1, 10);
        });
    }

    [Fact]
    public void SetTriangleSide_ThrowsNegativeValueException_WhenSideValuesInvalid()
    {
        Assert.Throws<NonPositiveValueException>(() =>
        {
            var triangle = new Triangle(1, 1, 1);
            triangle.A = -1;
        });
        Assert.Throws<NonPositiveValueException>(() =>
        {
            var triangle = new Triangle(1, 1, 1);
            triangle.B = -1;
        });
        Assert.Throws<NonPositiveValueException>(() =>
        {
            var triangle = new Triangle(1, 1, 1);
            triangle.C = -1;
        });
    }

    [Fact]
    public void SetTriangleSide_ThrowsInvalidTriangleSideValue_WhenSideValuesInvalid()
    {
        Assert.Throws<InvalidTriangleSideException>(() =>
        {
            var triangle = new Triangle(1, 1, 1);
            triangle.A = 10;
        });
        Assert.Throws<InvalidTriangleSideException>(() =>
        {
            var triangle = new Triangle(1, 1, 1);
            triangle.B = 10;
        });
        Assert.Throws<InvalidTriangleSideException>(() =>
        {
            var triangle = new Triangle(1, 1, 1);
            triangle.C = 10;
        });
    }

    [Theory]
    [InlineData(4, 3, 5, 6)]
    [InlineData(1, 1, 1, 0.433013)]
    [InlineData(4, 5, 6, 9.921567)]
    [InlineData(78, 69, 123, 2468.691961)]
    public void GetTriangleArea(double a, double b, double c, double expectedArea)
    {
        var triangle = new Triangle(a, b, c);

        Assert.True(Math.Abs(expectedArea - triangle.Area) < 1e-6);
    }
}