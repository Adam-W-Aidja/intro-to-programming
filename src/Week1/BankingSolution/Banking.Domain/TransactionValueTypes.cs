﻿namespace Banking.Domain;
public record TransactionValueTypes
{
    public record Deposit : TransactionValueTypes { }
    public record Withdrawl : TransactionValueTypes { }
    public record Balance : TransactionValueTypes { }
}

//deposit --decimal
//withdraw --decimal
//getbalance -- decimal
