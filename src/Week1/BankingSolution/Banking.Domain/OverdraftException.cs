namespace Banking.Domain;

public class OverdraftException : ArgumentOutOfRangeException { }

namespace Banking.Domain;

public class TimeBasedBonusCalculator
{
    public TimeBasedBonusCalculator()
    {
    }

    public decimal CalculateBonusForAccountDeposit(decimal balance, decimal deposit)
    {
        return balance >= 5000M ? deposit * .10M : 0;
    }
}

namespace Banking.Domain;

public class TimeBasedBonusCalculator
{
    public TimeBasedBonusCalculator()
    {
    }
}