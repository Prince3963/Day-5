using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_50.Custom_Exception
{
    public class BankAccount
    {
        public double Balance { get; set; }
        public BankAccount(double balance)
        {
            this.Balance = balance;
        }

        public void withdraw(double amount)
        {
            try
            {
                if(amount > Balance)
                {
                    throw new InsufficientBalanceException($"Insufficient balance for the withdrawal, you have total {Balance}");
                }

                Balance -= amount;
                Console.WriteLine($"Withdrawal of {amount} successful. Remaining balance: {Balance}");
            }catch(Exception ex)
            {
                throw new InsufficientBalanceException("Error during withdrawal", ex);
            }
        }
    }
}
