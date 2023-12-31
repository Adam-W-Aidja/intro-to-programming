﻿
using NSubstitute;

namespace StringCalculator;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator;
    public StringCalculatorTests()
    {
        _calculator = new StringCalculator(Substitute.For<ILogger>());
    }
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void ArbitraryNumbers()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,2,3,4,5,6,7,8,9");
        Assert.Equal(45, result);
    }

}
