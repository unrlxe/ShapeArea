namespace ShapeArea;

public class Circle : Shape
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        set
        {
            if (value <= 0)
            {
                throw new NonPositiveValueException();
            }

            _radius = value;
        }
    }

    public override double Area => Math.PI * Math.Pow(Radius, 2);

    public Circle(double radius)
    {
        Radius = radius;
    }
}