using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Revision
{
    public class Menu
    {
        Calculator calculator = new Calculator();
        int number;
        bool cont = true;
        public Menu()
        {

            while (cont)
            {
                int a;
                int b;
                int res;

                Console.WriteLine("Enter you first number: ");
                a = InputValidatorInt();

                Console.WriteLine("Enter you second number: ");
                b = InputValidatorInt();

                Console.WriteLine("+----------Calculator----------+");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("+------------------------------+");
                Console.WriteLine("Enter the corresponding number to your operator");

                
                while (!int.TryParse(Console.ReadLine(), out res) || res < 1 || res > 4)
                {
                    Console.WriteLine("Invalid number, please try again!");
                }

                    int result;
                    switch (res)
                    {
                        case 1:
                            result = calculator.Add(a, b);
                            Console.WriteLine("the result is: " + result);
                            break;
                        case 2:
                            result = calculator.Subtract(a, b);
                            Console.WriteLine("the result is: " + result);
                            break;
                        case 3:
                            result = calculator.Multiply(a, b);
                            Console.WriteLine("the result is: " + result);
                            break;
                        case 4:
                            result = calculator.Divide(a, b);
                            Console.WriteLine("the result is: " + result);
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
            }

        }

        
        
        public int InputValidatorInt()
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out number))
            {
                number = int.Parse(input);
            }
            else
            {
                Console.WriteLine("Invalid input! Try again!");
            }

            return number;
        }
    }
}
