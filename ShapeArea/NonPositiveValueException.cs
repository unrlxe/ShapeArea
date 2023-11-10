namespace ShapeArea;

public class NonPositiveValueException : Exception
{
    public NonPositiveValueException() : base("Expected non-negative value")
    {
    }
}