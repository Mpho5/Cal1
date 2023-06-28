//This program lets the user to make calcultions using different operators
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace Cal1
{
    internal class Program
    { 
        static void Main(string[] args)

        {
            //Welcome message
            Console.WriteLine("Hello There!!");
            Console.WriteLine("Welcome to THEE calculator, YOU CAN COUNT ON US!!");
            Console.WriteLine("This calculator allows you to perform multiple operators. Follow the instructions below!");

            Console.WriteLine();

            //Initialize the variables
            int addition,subtract,division,multiply;

            //Prompt the user to enter 2 numbers
            Console.WriteLine("Enter the numbers you wanna perform make calculations on.");

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            //Prompt the user to tell us which operator they wanna use
            Console.WriteLine("Enter the operator (+ , -, *, / ): ");
            string opp = Console.ReadLine();

            Console.WriteLine();

            if (opp != "+" && opp != "-" && opp != "/" && opp != "*")
            {
                Console.WriteLine("Please enter the correct operator");
            }
            

                if (opp == "+")
                {

                    Console.WriteLine("You want to add the 2 numbers you have entered. Press Enter to show the results.");
                    Console.ReadKey();

                    addition = num1 + num2;
                    Console.WriteLine("This is the result! ");
                    Console.WriteLine("Results:" + num1 + " + " + num2 + " = " + addition);
                }
                else if (opp == "-")
                {
                    Console.WriteLine("You want to subtract the 2 numbers you have entered. Press Enter to show the results.");
                    Console.ReadKey();

                    subtract = num1 - num2;
                    Console.WriteLine("Results: " + num1 + "  - " + num2 + " = " + subtract);
                }
                else if (opp == "/")
                {

                    Console.WriteLine("You want to divide the 2 numbers you have entered. Press Enter to show the results.");
                    Console.ReadKey();

                    division = num1 / num2;
                    Console.WriteLine("Results: " + num1 + " / " + num2 + " = " + division);
                }
                else if (opp == "*")
                {
                    Console.WriteLine("You want to multiply the 2 numbers you have entered. Press Enter to show the results.");
                    Console.ReadKey();

                    multiply = num1 * num2;
                    Console.WriteLine("Results: " + num1 + " * " + num2 + " = " + multiply);
                }

            Console.WriteLine("Do you wish to perform another calculation(Y/N) ?");
        }
         

    }

}
