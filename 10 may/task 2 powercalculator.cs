using System;

public class PowerCalculator
{
    // Method to calculate power for two integers
    public static int CalculatePower(int baseNum, int exponent)
    {
        int result = 1;
        if (exponent > 0)
        {
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
        }
        else if (exponent < 0)
        {
            // Handle negative exponents by calculating the reciprocal of the positive power
            return 1 / CalculatePower(baseNum, -exponent);
        }
        return result;
    }

    // Method to calculate power for two doubles
    public static double CalculatePower(double baseNum, double exponent)
    {
        return Math.Pow(baseNum, exponent);
    }

    public static void Main(string[] args)
    {
        // result of 2^3
        int intBase = 2;
        int intExponent = 3;
        int intResult = CalculatePower(intBase, intExponent);
        Console.WriteLine($"{intBase}^{intExponent} = {intResult}");

        // result of 5.5^2
        double doubleBase = 5.5;
        double doubleExponent = 2;
        double doubleResult = CalculatePower(doubleBase, doubleExponent);
        Console.WriteLine($"{doubleBase}^{doubleExponent} = {doubleResult}");
    }
}  