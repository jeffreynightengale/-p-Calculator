using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("", "", "");
            
            Console.WriteLine($"What type of calculation would you like to use? (Addition, Subtratcion, Multiplication, or Division) >>");
            string calculate = Console.ReadLine();

            Console.WriteLine($"What is your first number? >>");
            string firstNumber = Console.ReadLine();
            double v1 = Convert.ToDouble(firstNumber);

            Console.WriteLine($"What is your second number? >>");
            string secondNumber = Console.ReadLine();
            double v2 = Convert.ToDouble(secondNumber);

            if (calculate.ToLower() == "addition")
            {
                calculate = Add(firstNumber, secondNumber);
            }
            else if (calculate.ToLower() == "subtraction")
            {

            }
            else if (calculate.ToLower() == "multiplication")
            {

            }
            else if (calculate.ToLower() == "division")
            {

            }
            else
            {
                Console.WriteLine("Please insert Addition, Subtraction, Multiplication, or Division.");
            }
        }

        static double Add(double v1, double v2) //always declare vvariables in parenthesis
        {
            double sum = v1 + v2;
            return sum;

            //return val1 + val2;
        }

        static double Subtract(double v1, double v2)
        {
            double sum = v1 - v2;
            return sum;
        }

        static double Mutliplication(double v1, double v2)
        {
            double sum = v1 * v2;
            return sum;
        }

        static double Division(double v1, double v2)
        {
            double sum = v1 / v2;
            return sum;
        }

        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            developerName = "Jeffrey Nightengale";
            className = "MIS 3013";
            dateOfWriting = "April 1, 2021";
        }
    }
}
