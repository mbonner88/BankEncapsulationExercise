using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            Console.WriteLine("Hello, bank customer. Press enter to check your balance, or type a deposit amount and press enter. Enter a capital X to exit.");            
            int depositAmount;
            string userInput = null;
            while (userInput != "X")
            {
                userInput = Console.ReadLine();
                if (userInput == "")
                {
                    Console.WriteLine($"Current balance:{account.GetBalance()}");
                }
                else if (int.TryParse(userInput, out depositAmount) == true)
                {
                    account.Deposit(depositAmount);
                    Console.WriteLine($"Deposit successful. Your new balance is: {account.GetBalance()}");
                }
                else if (userInput != "X")
                {
                    Console.WriteLine($"Invalid input. Please use numerical characters only.");
                }
                else
                {
                    Console.WriteLine($"Exit requested. Now closing...");
                }
            };

            Console.WriteLine($"Thank you, and have a good day.");
        }
    }
}
