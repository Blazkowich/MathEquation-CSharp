using System;

public class EquationHelper
{
    public static string SolveQuadraticEquation(double a, double b, double c)
    {
        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            return TwoSolutionResult((-b + Math.Sqrt(discriminant)) / (2 * a),
                (-b - Math.Sqrt(discriminant)) / (2 * a));
        }
        else if (discriminant == 0)
        {
            return OneSolutionResult(-b / (2 * a));
        }
        else
        {
            return NoSolutionResult();
        }
    }

    public static string TwoSolutionResult(double x1, double x2)
    {
        return $"The Equation has Two Solutins x1 = {x1}, x2 = {x2}";
    }

    private static string OneSolutionResult(double x)
    {
        return $"The Equation Has One Solution x = {x}";
    }

    private static string NoSolutionResult()
    {
        return $"The Equation Has Not a Solution";
    }
}
