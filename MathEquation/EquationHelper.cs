using System;

public class EquationHelper
{
    
    public static string SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;
        Console.WriteLine("\nDiscriminant is: " + discriminant+"\n");
        if (discriminant > 0)
        {
            return TwoSolutionResult(a, b, discriminant);
        }
        else if (discriminant == 0)
        {
            return OneSolutionResult(a, b);
        }
        else
        {
            return NoSolutionResult();
        }
    }

    public static string TwoSolutionResult(double a, double b, double disc)
    {
        double x1 = (-b + Math.Sqrt(disc)) / (2 * a);
        double x2 = (-b - Math.Sqrt(disc)) / (2 * a);

        return $"The Equation has Two Solutins x1 = {Math.Round(x1,2)}, x2 = {Math.Round(x2,2)}";
    }

    private static string OneSolutionResult(double a, double b)
    {
        double x = -b / (2 * a);
        return $"The Equation Has One Solution x = {x}";
    }

    private static string NoSolutionResult()
    {
        return $"The Equation Has Not a Solution";
    }
}
