namespace unittestingDemo.core;

public static class Calculater
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }

    public static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new System.DivideByZeroException("Cannot divide by zero.");
        }
        return a / b;
    }

    public static bool IsEven(int a)
    {
        return a % 2 == 0;
    }
}