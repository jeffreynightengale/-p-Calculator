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
            string final;
            
            do
            {
                double answer = 0;
                if (calculate.ToLower() == "addition")
                {
                    answer = Add(v1, v2);
                }
                else if (calculate.ToLower() == "subtraction")
                {
                    answer = Subtract(v1, v2);
                }
                else if (calculate.ToLower() == "multiplication")
                {
                    answer = Mutliply(v1, v2);
                }
                else if (calculate.ToLower() == "division")
                {
                    answer = Divide(v1, v2);
                }
                Console.WriteLine($"Your answer is {answer}");

                Console.WriteLine($"Do you want to do another calculation");
                final = Console.ReadLine();
                if (final.ToLower()[0] == 'n')
                {
                    Console.WriteLine("Thank you for using our service");
                    Environment.Exit(-1);
                }

                Console.WriteLine($"Would you like to use your previous answer as your first value?");
                string useFirstValue = Console.ReadLine();
                if (useFirstValue.ToLower()[0] == 'y')
                {
                    Console.WriteLine($"What type of calculation would you like to use? (Addition, Subtratcion, Multiplication, or Division) >>");
                    calculate = Console.ReadLine();

                    v1 = answer;
                    Console.WriteLine($"What is your second number? >>");
                    secondNumber = Console.ReadLine();
                    v2 = Convert.ToDouble(secondNumber);

                }
                else
                {
                    Console.WriteLine($"What type of calculation would you like to use? (Addition, Subtratcion, Multiplication, or Division) >>");
                    calculate = Console.ReadLine();

                    Console.WriteLine($"What is your first number? >>");
                    firstNumber = Console.ReadLine();
                    v1 = Convert.ToDouble(firstNumber);

                    Console.WriteLine($"What is your second number? >>");
                    secondNumber = Console.ReadLine();
                    v2 = Convert.ToDouble(secondNumber);
                }
            }while (final.ToLower()[0] == 'y');

        }
        /// <summary>
        /// This is used when the user wants to do Addition
        /// </summary>
        /// <param name="v1">First variable they input</param>
        /// <param name="v2">Second variable they input</param>
        /// <returns>Returns the sum of the two numbers (5+5)</returns>
        static double Add(double v1, double v2) //always declare variables in parenthesis
        {
            double sum = v1 + v2;
            return sum;

            //return val1 + val2;
        }
        /// <summary>
        /// This is used when the user wants to do addition
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        static double Subtract(double v1, double v2)
        {
            double sum = v1 - v2;
            return sum;
        }

        static double Mutliply(double v1, double v2)
        {
            double sum = v1 * v2;
            return sum;
        }

        static double Divide(double v1, double v2)
        {
            double sum = v1 / v2;
            return sum;
        }

        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            developerName = "Jeffrey Nightengale";
            className = "MIS 3013";
            dateOfWriting = "April 1, 2021";

            Console.WriteLine($"{developerName} {className} {dateOfWriting}");
            Console.WriteLine();
        }
    }
}
