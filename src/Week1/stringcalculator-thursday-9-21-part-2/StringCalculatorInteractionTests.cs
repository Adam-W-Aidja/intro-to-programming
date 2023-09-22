using NSubstitute;

namespace StringCalculator;
public class StringCalculatorInteractionTests
{

    [Fact]
    [InlineData("9", "9")]
    [InlineData("10", "10")]
    public void ResultsAreWrittenToALogger(string numbers, string logged)
    {
        var fakeLogger = Substitute.For<ILogger>();
        var calculator = new StringCalculator(fakeLogger);


        calculator.Add(numbers);

        // THEN??? What am I going to assert on?
        fakeLogger.Received().Write(logged);

    }
}