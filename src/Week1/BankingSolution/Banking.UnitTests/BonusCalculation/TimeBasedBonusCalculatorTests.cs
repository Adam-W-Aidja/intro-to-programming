using Banking.Domain.Banking.Domain;

namespace Banking.UnitTests.BonusCalculation;
public class TimeBasedBonusCalculatorTests
{
    [Theory]
    [InlineData(5000, 100, 10)]
    [InlineData(6500, 200, 20)]
    public void MakingDepositsOutsideOfBusinessHours(decimal balance, decimal deposit, decimal expectedBonus)
    {
        var calculator = new TimeBasedBonusCalculator();

        decimal bonus = calculator.CalculateBonusForAccountDeposit(balance, deposit);

        Assert.Equal(expectedBonus, bonus);
    }
}


/*
*     Given you have an account with a balance of 5000 or more
    And you make your deposit outside of business hours
    When you make a deposit
    Then you get 10% added to your deposit (as before)

    Given you have an account with a balance of 5000 or more
    And you make your deposit during business hours
    When you make a deposit
    Then

    balance => deposit => bonus
    5000-5999.99 -> 100 => 10 (10%)
    6000-6999.99 -> 100 => 11 (11%)
    7000-7999.99 -> 100 => 12 (12%)
    8000+        -> 100 => 13 (13%)
*/