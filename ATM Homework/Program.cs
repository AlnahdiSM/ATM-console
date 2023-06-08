using System;

class Program
{
    static void Main()
    {
        int balance = 1000;
        Console.Title = "ATM HOMEWORK";

        while (true)
        {
            Console.WriteLine("ATM Menu:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine($"Your current balance is: {balance}");
            }
            else if (choice == "2")
            {
                Console.Write("Enter the amount to withdraw: ");
                int amount;
                if (int.TryParse(Console.ReadLine(), out amount))
                {
                    if (amount > 0 && amount <= balance)
                    {
                        balance -= amount;
                        Console.WriteLine("Withdrawal successful. Please take your cash.");
                    }
                    else if (amount <= 0)
                    {
                        Console.WriteLine("Invalid amount. Please enter a positive value.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter the amount to deposit: ");
                int amount;
                if (int.TryParse(Console.ReadLine(), out amount))
                {
                    if (amount > 0)
                    {
                        balance += amount;
                        Console.WriteLine("Deposit successful.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount. Please enter a positive value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please try again.");
            }

            Console.WriteLine();
        }
    }
}
