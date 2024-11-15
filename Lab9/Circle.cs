public class Circle
{
    private double radius;
    private const double PI = 3.14159;

    // no argument Constructor
    public Circle()
    {
        radius = 0;
    }

    // one argument Constructor
    public Circle(double rad)
    {
        // make sure the parameter is not negative
        if (rad < 0)
            radius = 0;
        else
            radius = rad;
    }

    // Radius Property
    public double Radius
    {
        // return the private data value on
        get { return radius; }
        // make sure the implicit parameter is not negative on set
        set
        {
            if (value < 0)
                radius = 0;
            else
                radius = value;
        }
    }

    // GetArea Method
    public double GetArea()
    {
        double area;
        // compute the area = radius^2 * PI
        area = radius * radius * PI;
        return area;
    }

    public double GetCircumference()
    {
        return 2 * PI * radius;
    }

    public static Circle operator +(Circle circle1, Circle circle2)
    {
        Circle circle3 = new Circle();
        double sumArea,
            newRadius;
        // compute the sum of the areas of the two circles
        sumArea = circle1.GetArea() + circle2.GetArea();
        // compute the radius of the new circle
        newRadius = Math.Sqrt(sumArea) / PI;
        // assign the radius to the new circle
        circle3.Radius = newRadius;
        // return the new circle
        return circle3;
    }
}
