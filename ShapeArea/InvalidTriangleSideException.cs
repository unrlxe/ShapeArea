namespace ShapeArea;

public class InvalidTriangleSideException : Exception
{
    public InvalidTriangleSideException() : base("Triangle with such sides doesnt exists")
    {
    }
}