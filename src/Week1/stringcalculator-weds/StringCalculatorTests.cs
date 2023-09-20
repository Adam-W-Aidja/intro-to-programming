
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("12", 12)]
    [InlineData("108", 108)]
    public void SingleDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("108,2", 110)]
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3,4,5", 15)]
    [InlineData("108,2,10,20", 140)]
    public void UnlimitedNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,3\n4,5", 13)]
    [InlineData("100,2\n10\n20", 132)]
    public void NewLineHandler(string numbers, int expected)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(numbers);
        Assert.Equal(expected, result);
    }
}
