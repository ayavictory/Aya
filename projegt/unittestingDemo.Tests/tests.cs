using Xunit; 
using unittestingDemo.core; 

namespace unittestingDemo.Tests;

public class CalculaterTests
{
    [Fact]
    public void Multiply_TwoPositiveNumbers_ReturnsCorrectProduct()
    {
        
        int a = 3;
        int b = 2;

        
        int result = Calculater.Multiply(a, b);

        
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_NumberWithZero_ReturnsZero()
    {
        
        int a = 5;
        int b = 0;

        
        int result = Calculater.Multiply(a, b);

        
        Assert.Equal(0, result);
    }

    [Fact]
    public void Multiply_NegativeAndPositiveNumber_ReturnsNegative()
    {
        
        int a = 3;
        int b = -2;

        
        int result = Calculater.Multiply(a, b);

        
        Assert.Equal(-6, result);
    }

    [Fact]
    public void Multiply_TwoNegativeNumbers_ReturnsPositive()
    {
        
        int a = -3;
        int b = -2;

        
        int result = Calculater.Multiply(a, b);

        
        Assert.Equal(6, result);
    }

    
    [Fact]
    public void Divide_PositiveNumbers_ReturnsCorrectResult()
    {
        
        int a = 6;
        int b = 2;

        
        int result = Calculater.Divide(a, b);

        
        Assert.Equal(3, result);
    }

    [Fact]
    public void Divide_NegativeDividend_ReturnsCorrectResult()
    {
       
        int a = -6;
        int b = 2;

        
        int result = Calculater.Divide(a, b);

        
        Assert.Equal(-3, result);
    }

    [Fact]
    public void Divide_ByOne_ReturnsSameNumber()
    {
        
        int a = 5;
        int b = 1;

        
        int result = Calculater.Divide(a, b);

        
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
       
        int a = 10;
        int b = 0;

        
        Assert.Throws<System.DivideByZeroException>(() => Calculater.Divide(a, b));
    }

    
    [Fact]
    public void IsEven_EvenNumber_ReturnsTrue()
    {
        
        int a = 4;

        
        bool result = Calculater.IsEven(a);

        
        Assert.True(result);
    }

    [Fact]
    public void IsEven_OddNumber_ReturnsFalse()
    {
        
        int a = 3;

        
        bool result = Calculater.IsEven(a);

        
        Assert.False(result);
    }

    [Fact]
    public void IsEven_Zero_ReturnsTrue()
    {
        
        int a = 0;

        
        bool result = Calculater.IsEven(a);

        
        Assert.True(result);
    }
}