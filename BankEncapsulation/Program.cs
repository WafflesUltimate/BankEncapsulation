using System.Globalization;

namespace BankEncapsulation
{

    public class BankAccount
    {
        public BankAccount() { }

        private double balance = 0;

        public double Deposit(double amount)
        {
           return balance += amount;
        }

        public double Withdraw(double amount)
        {
            return balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }


    public class Program
    {

        public static void BankApp() 
        {
            string userInput;
            BankAccount account = new BankAccount();
            var currentbalance = account.GetBalance();
            Console.WriteLine($"Hi, User, your current balance is : ${currentbalance}");
            do
            {
                Console.WriteLine("Do you want to deposit or withdraw? " +
            "Type d to deposit or w to withdraw");

                userInput = Console.ReadLine();

            } while (userInput != "d" && userInput != "w");

                if (userInput == "d")
            {
                Console.WriteLine("How much do you want to deposit? Please enter a number.");
                userInput = Console.ReadLine();

                double a;
                var numparseResult = double.Parse(userInput);

                while(numparseResult == 0 || numparseResult < 0) 
                {
                    Console.WriteLine("How much do you want to deposit? Please enter a number.");
                    userInput = Console.ReadLine();
                    numparseResult = double.Parse(userInput);
                }
                account.Deposit(numparseResult);
                currentbalance = account.GetBalance();
                Console.WriteLine($"You balance is now: ${currentbalance}");
            }

            if (userInput == "w")
            {
                Console.WriteLine("How much do you want to withdraw? Please enter a number.");
                userInput = Console.ReadLine();

                double a;
                var numparseResult = double.Parse(userInput);

                while (numparseResult == 0 || numparseResult < 0)
                {
                    Console.WriteLine("How much do you want to deposit? Please enter a number.");
                    userInput = Console.ReadLine();
                    numparseResult = double.Parse(userInput);
                }
                account.Withdraw(numparseResult);
                currentbalance = account.GetBalance();
                Console.WriteLine($"You balance is now: ${currentbalance}");
            }

        }


        static void Main(string[] args)
        {
            BankApp();
        }
    }
}
