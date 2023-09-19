using Banking.Domain;

namespace Banking.UnitTests.BankAccount;
public class OverdraftNotAllowed
{
    [Fact]
    public void BalanceDoesNotDecreaseOnOverfraft()
    {
        //Given
        var account = new Account();
        var openingBalance = account.GetBalance();

        var amountToWithdraw = account.GetBalance() + .01M;

        //When
        try
        {
            account.Withdraw(amountToWithdraw);
        }
        catch (Exception)
        {

            //ignore
        }
        finally
        {
            Assert.Equal(openingBalance, account.GetBalance());
        }


    }

    [Fact]
    public void OverdraftThrowsAnException()
    {

        // Given
        var account = new Account();
        var openingBalance = account.GetBalance();

        var amountToWithdraw = account.GetBalance() + .01M;

        // When & then
        Assert.Throws<OverdraftException>(() =>
        {
            account.Withdraw(amountToWithdraw);
        });


        // Then
    }
}
