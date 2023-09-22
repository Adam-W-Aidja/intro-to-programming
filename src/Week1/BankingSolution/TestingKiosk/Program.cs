

//welcome to the bank
//show balance
//ask if they want to deposit or withraw or quit
// collect amount - apply it tot he account
// show them their new balance.
using Banking.Domain;



Console.WriteLine("Welcome to the Bank!");
var account = new Account(new StandardBonusCalculator());



while (true)
{
    Console.WriteLine($"Your Current Balance is {account.GetBalance():c}");
    Console.Write("Do you want to make a (d)eposit, (w)ithdrawal, or (q)uit? ");
    var response = Console.ReadLine();
    if (response == "d")
    {
        Console.Write("amount to deposit: ");
        var amountEntered = Console.ReadLine();
        if (amountEntered != null)
        {
            var depositAmount = int.Parse(amountEntered);
            var deposit = TransactionValueTypes.Deposit.CreateFrom(depositAmount);
            account.Deposit(deposit);
        }
    }
    if (response == "w")
    {
        Console.Write("amount to withdraw: ");
        var amountEntered = Console.ReadLine();
        if (amountEntered != null)
        {
            var depositAmount = int.Parse(amountEntered);
            var withdrawal = TransactionValueTypes.Withdrawal.CreateFrom(depositAmount);
            account.Withdraw(withdrawal);
        }
    }
    if (response == "q")
    {



        break; // quit looping



    }
}