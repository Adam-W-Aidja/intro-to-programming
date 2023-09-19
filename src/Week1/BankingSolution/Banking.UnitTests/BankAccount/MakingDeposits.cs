using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class MakingDeposits
{
    [Fact]

    public void MakingADepositIncreasesThebALANCE()
    {
        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 125.23M;

        // When
        account.Deposit(amountToDeposit);

        // Then
        Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
    }
}
