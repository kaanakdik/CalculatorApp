using Xunit;
using CalculatorApp;

public class CalculatorTests
{
    [Fact]
    public void Add_Works()
    {
        var calc = new Calculator();
        Assert.Equal(11, calc.Add(3, 2, 6));
    }

    [Fact]
    public void Subtract_Works()
    {
        var calc = new Calculator();
        Assert.Equal(2, calc.Subtract(5, 3));
    }

    [Fact]
    public void Multiply_Works()
    {
        var calc = new Calculator();
        Assert.Equal(12, calc.Multiply(4, 3));
    }

    [Fact]
    public void Divide_Works()
    {
        var calc = new Calculator();
        Assert.Equal(5, calc.Divide(10, 2));
    }

    [Fact]
    public void Divide_By_Zero_Throws()
    {
        var calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(5, 0));
    }
}
