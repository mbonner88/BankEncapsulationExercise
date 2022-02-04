using System;
namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
