using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

class Program
{
    static void Main()
    {

        int term1, term2, term3;
        bool validInput = false;
        string operator1 = "o";
        string operator2 = "o";

        Console.WriteLine("Enter the first term: "); // asks the user for the first term and sets term1 variable
        term1 = Convert.ToInt32(Console.ReadLine());

        while (!validInput) // asks the user to write the first operator, and also checks if the input is valid
        {
            Console.WriteLine("Enter first operator: ");
            operator1 = Console.ReadLine();
            if (operator1 == "+" || operator1 == "-" || operator1 == "*" || operator1 == "/")
                validInput = true;
            else
            {
                Console.WriteLine("Invalid Input");
                Console.Beep();
            }
        }

        Console.WriteLine("Enter the second term: "); // asks the user for the second term and sets term2 variable
        term2 = Convert.ToInt32(Console.ReadLine());

        validInput = false; // sets validinput variable to false so it will loop when asking user to input the second operator

        while (!validInput) // asks the user to write the second operator, and also checks if the input is valid
        {
            Console.WriteLine("Enter the second operator: ");
            operator2 = Console.ReadLine();
            if (operator2 == "+" || operator2 == "-" || operator2 == "*" || operator2 == "/")
                validInput = true;
            else
            {
                Console.WriteLine("Invalid Input");
                Console.Beep();
            }
        }
        Console.WriteLine("Enter third term: "); // asks the user for the third term and sets term3 variable
        term3 = Convert.ToInt32(Console.ReadLine());
        // checks the operators and then prints out the whole equation depending on operators and terms
        if (operator1.Equals("+") && operator2.Equals("+"))
            Console.WriteLine("{0} + {1} + {2} = {3}", term1, term2, term3, term1 + term2 + term3);
        if (operator1.Equals("+") && operator2.Equals("-"))
            Console.WriteLine("{0} + {1} - {2} = {3}", term1, term2, term3, term1 + term2 - term3);
        if (operator1.Equals("+") && operator2.Equals("*"))
            Console.WriteLine("{0} + {1} * {2} = {3}", term1, term2, term3, term1 + term2 * term3);
        if (operator1.Equals("+") && operator2.Equals("/"))
            Console.WriteLine("{0} + {1} / {2} = {3}", term1, term2, term3, term1 + term2 / term3);

        if (operator1.Equals("-") && operator2.Equals("+"))
            Console.WriteLine("{0} - {1} + {2} = {3}", term1, term2, term3, term1 - term2 + term3);
        if (operator1.Equals("-") && operator2.Equals("-"))
            Console.WriteLine("{0} - {1} - {2} = {3}", term1, term2, term3, term1 - term2 - term3);
        if (operator1.Equals("-") && operator2.Equals("*"))
            Console.WriteLine("{0} - {1} * {2} = {3}", term1, term2, term3, term1 - term2 * term3);
        if (operator1.Equals("-") && operator2.Equals("/"))
            Console.WriteLine("{0} - {1} / {2} = {3}", term1, term2, term3, term1 - term2 / term3);

        if (operator1.Equals("*") && operator2.Equals("+"))
            Console.WriteLine("{0} * {1} + {2} = {3}", term1, term2, term3, term1 * term2 + term3);
        if (operator1.Equals("*") && operator2.Equals("-"))
            Console.WriteLine("{0} * {1} - {2} = {3}", term1, term2, term3, term1 * term2 - term3);
        if (operator1.Equals("*") && operator2.Equals("*"))
            Console.WriteLine("{0} * {1} * {2} = {3}", term1, term2, term3, term1 * term2 * term3);
        if (operator1.Equals("*") && operator2.Equals("/"))
            Console.WriteLine("{0} * {1} / {2} = {3}", term1, term2, term3, term1 * term2 / term3);

        if (operator1.Equals("/") && operator2.Equals("+"))
            Console.WriteLine("{0} / {1} + {2} = {3}", term1, term2, term3, term1 / term2 + term3);
        if (operator1.Equals("/") && operator2.Equals("-"))
            Console.WriteLine("{0} / {1} - {2} = {3}", term1, term2, term3, term1 / term2 - term3);
        if (operator1.Equals("/") && operator2.Equals("*"))
            Console.WriteLine("{0} / {1} * {2} = {3}", term1, term2, term3, term1 / term2 * term3);
        if (operator1.Equals("/") && operator2.Equals("/"))
            Console.WriteLine("{0} / {1} / {2} = {3}", term1, term2, term3, term1 / term2 / term3);
        Console.Read(); // only there for a clean ending
    }
}
