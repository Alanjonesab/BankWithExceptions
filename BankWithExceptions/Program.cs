using BankWithExceptions.Entities;
using BankWithExceptions.Entities.Exceptions;
using System;
using System.Globalization;

namespace BankWithExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial Balance: $ ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: $ ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, name, balance, limit);

                Console.WriteLine();
                Console.WriteLine();

                int option = 0;
                Console.WriteLine("Choose an operation below:\n" +
                    "1 - Deposit\n" +
                    "2 - Withdraw");
                Console.Write("Chosen option: ");
                option = int.Parse(Console.ReadLine());
                
                
                switch (option)
                {

                    case 1:
                        Console.Write("Enter amount for deposit: $ ");
                        double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        account.Deposit(amount);
                        break;
                    case 2:
                        Console.Write("Enter amount for withdraw: $ ");
                        amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        account.Withdraw(amount);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }
            }
            catch(DomainException e)
            {
                Console.WriteLine("Error in Operation: " + e.Message);
            }
            
            
            

        }
    }
}
