using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        float interestRate;
        
        if (balance < 0)
        {
            interestRate = -3.213f;
        } else if (balance is >= 0 and < 1000)
        {
            interestRate = .5f;
        }else if (balance is >= 1000 and <5000)
        {
            interestRate = 1.621f;
        }
        else
        {
            interestRate = 2.475f;
        }
        return interestRate;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return (decimal)InterestRate(balance) / 100 * Math.Abs(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        var years = 0;
        var newBalance = balance;

        while (newBalance < targetBalance)
        {
            newBalance = AnnualBalanceUpdate(newBalance);
            years++;
        }
        return years;
    }
}
