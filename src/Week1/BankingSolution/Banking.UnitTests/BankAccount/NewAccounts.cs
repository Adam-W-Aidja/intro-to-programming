using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveTheCorrectOpeningBalance()
    {
        //Write the code we wish we had
        // given
        var account = new Account();

        //when
        decimal balance = account.GetBalance();
        //then
        Assert.Equal(5000M, balance);
    }
}
