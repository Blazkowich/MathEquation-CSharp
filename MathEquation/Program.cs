using System;

public class Program
{
    public static void Main(string[] args)
    {
        double a = UserInteractionHelper.GetCoefficient("A");
        double b = UserInteractionHelper.GetCoefficient("B");
        double c = UserInteractionHelper.GetCoefficient("C");

        EquationHelper.SolveQuadraticEquation(a, b, c);
    }
}
