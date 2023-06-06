using System;

public class UserInteractionHelper
{

    public double a;
    public double b;
    public double c;

    public static double GetCoefficient(string coefficientName)
    {
        double coefficient;
        bool isValid;

        do
        {
            Console.Write($"Enter the value for coefficient {coefficientName}: ");
            string input = Console.ReadLine();
            isValid = double.TryParse(input, out coefficient);

            if (!isValid)
            {
                Console.WriteLine("Invalid input. Please enter a valid numerical value.");
            }
        } while (!isValid);

        return coefficient;
    }

    public void GetInput()
    {    
        a = GetCoefficient("A");
        b = GetCoefficient("B");
        c = GetCoefficient("C");   
    }

    public void GetResult()
    {
        Console.WriteLine(EquationHelper.SolveQuadraticEquation(a, b, c));
    }
}
