using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main()
        {
            // Welcome the user and ask them for input

            Console.WriteLine("Hello welcome to my calculator!");
            
            Console.WriteLine("Would you like to add, subtract, multiply or divide? ");
            // convert the string value to lower case
            string operand = Console.ReadLine().ToLower();


            Console.WriteLine("Please enter two numbers, hitting enter after each ");
            // parse string input to int type
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());

            // declare total as a float type
            float total = 0;

            // conditional statements for operands that call appropriate methods below
            if (operand == "add" || operand == "+" )
            {
                total = addNumbers(int1, int2);
            }
            else if (operand == "subtract" || operand == "-")
            {
                total = subtractNumbers(int1, int2);
            }
            else if (operand == "multiply" || operand == "*")
            {
                total = multiplyNumbers(int1, int2);
            }
            else if (operand == "divide" || operand == "/")
            {
                total = divideNumbers(int1, int2);
            }
            
            // result that is sent back from method call is written to the console
            Console.WriteLine("The total is {0}", total);
            Main();
        }

        // methods for each operand
    public static int addNumbers(int int1, int int2)
        {
            int total = int1 + int2;
            return total;
        }
    
    public static int subtractNumbers(int int1, int int2)
        {
            int total = int1 - int2;
            return total;
        }
    
    public static int multiplyNumbers(int int1, int int2)
        {
            int total = int1 * int2;
            return total;
        }
    public static float divideNumbers(float int1, float int2)
        {

            float total = (int1 / int2);
            return total;
        }
    }
}
