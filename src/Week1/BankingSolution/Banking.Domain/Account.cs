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
}