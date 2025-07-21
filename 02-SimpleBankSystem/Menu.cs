using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace BankSystem
{
    public class Menu
    {
        public int option;
        public int number;
        public bool cont;
        public Menu()
        {
            Bank bank = new Bank();
            Operations operations = new Operations(bank);

            operations.WelcomeMessage();

            do
            {
                Console.WriteLine("+----------------------------+");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.WriteLine("+----------------------------+");

                Console.WriteLine("Please enter the number corresponding to your option");
                option = InputValidator();

                while ( option < 1 || option > 4)
                {
                    Console.WriteLine("Invalid number, please try again!");
                }

                int output;

                switch (option)
                {
                    case 1:
                        output = operations.ViewBalance();
                        Console.WriteLine(output);
                        break;
                    case 2:
                        operations.Deposit();
                        break;
                    case 3:
                        operations.Withdraw();
                        break;
                    case 4:
                        System.Environment.Exit(1);
                        break;
                }

                Console.WriteLine("Would you like to continue (y/n) ?: ");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                    Console.WriteLine("Thank you for using the calculator!");
                    Console.WriteLine("Exiting");

                }

            } while (cont);
            

        }

        public int InputValidator()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out int validNumber))
                {
                    return validNumber;
                }
                Console.WriteLine("Invalid input! Try Again!");
            }
        }
    }
}
