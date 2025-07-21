using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankSystem
{
    public class Operations
    {
        private Bank bank;
        public Operations(Bank bank)
        {
            this.bank = bank;
        }

        public int ViewBalance()
        {
            var Balance = bank.Balance;

            return Balance; 
        }

        public void Deposit()
        {
            var number = 0;
            Console.WriteLine("Please enter the amount you want to deposit: ");

            while (!int.TryParse(Console.ReadLine(), out number) || number < 1 )
            {
                Console.WriteLine("You can't deposit that! Try Again!");
            }

            bank.Balance = number + bank.Balance;

            Console.WriteLine("Amount deposited succesfully");

        }

        public bool Withdraw()
        {
            var Balance = bank.Balance;
            var number = 0;

            if (Balance < 100)
            {
                Console.WriteLine("You account has too little to withdraw!");
                return false;
            }

            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine("You can't withdraw that! Try Again!");
            }

            if (number > bank.Balance)
            {
                Console.WriteLine("Your cannot withdraw more than your balance!");
                return false;
            }

            bank.Balance = bank.Balance - number;
            Console.WriteLine("Amount withdrawn succesfully");
            return true;

        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Bank!");
            Console.WriteLine("Enter your name to create an account: ");
            bank.Name = Console.ReadLine();

            Console.WriteLine($"Hello, {bank.Name} What would you like to do?");
        }
    }
}
