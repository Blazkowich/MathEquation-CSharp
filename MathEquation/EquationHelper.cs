using System;

public class EquationHelper
{
    public static void SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"The quadratic equation has two solutions: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"The quadratic equation has one solution: x = {x}");
        }
        else
        {
            Console.WriteLine("The quadratic equation has no real solutions");
        }
    }
}
