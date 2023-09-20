
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }

        var numberSplit = numbers.Split(',', '\n');
        var finalSum = 0;

        foreach (var number in numberSplit)
        {
            finalSum += int.Parse(number);
        }

        return finalSum;
    }
}
