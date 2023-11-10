namespace ShapeArea;

public class Triangle : Shape
{
    private double _a;
    private double _b;
    private double _c;

    public double A
    {
        get => _a;
        set
        {
            if (value <= 0)
            {
                throw new NonPositiveValueException();
            }

            if (B != 0 && C != 0 && !IsTriangleValid(value, B, C))
            {
                throw new InvalidTriangleSideException();
            }

            _a = value;
        }
    }

    public double B
    {
        get => _b;
        set
        {
            if (value <= 0)
            {
                throw new NonPositiveValueException();
            }

            if (A != 0 && C != 0 && !IsTriangleValid(value, A, C))
            {
                throw new InvalidTriangleSideException();
            }

            _b = value;
        }
    }

    public double C
    {
        get => _c;
        set
        {
            if (value <= 0)
            {
                throw new NonPositiveValueException();
            }

            if (A != 0 && B != 0 && !IsTriangleValid(value, A, B))
            {
                throw new InvalidTriangleSideException();
            }

            _c = value;
        }
    }

    public override double Area => AreaInternal();
    public bool IsRight => IsRightInternal();

    public Triangle(double a, double b, double c)
    {
        if (!IsTriangleValid(a, b, c))
        {
            throw new InvalidTriangleSideException();
        }

        A = a;
        B = b;
        C = c;
    }

    private double AreaInternal()
    {
        var p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    private bool IsRightInternal()
    {
        return
            Math.Abs(Math.Pow(A, 2) + Math.Pow(B, 2) - Math.Pow(C, 2)) < 1e-10
            || Math.Abs(Math.Pow(C, 2) + Math.Pow(B, 2) - Math.Pow(A, 2)) < 1e-10
            || Math.Abs(Math.Pow(A, 2) + Math.Pow(C, 2) - Math.Pow(B, 2)) < 1e-10;
    }

    private bool IsTriangleValid(double a, double b, double c)
    {
        return a < b + c
               && b < a + c
               && c < a + b;
    }
}