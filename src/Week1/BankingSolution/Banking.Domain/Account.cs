namespace Banking.Domain;

public class Account
{
    private decimal _balance = 5000M;

    public void Deposit(decimal amountToDeposit)
    {
        //_balance = _balance + amountToDeposit;
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
        // slime it
        return _balance; // JFHCI
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        GuardHasSufficientFunds(amountToWithdraw);

        _balance -= amountToWithdraw;
    }

    private void GuardHasSufficientFunds(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            throw new OverdraftException();
        }
    }
}
