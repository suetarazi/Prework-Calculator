using System;

namespace Prework_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to my calculator!");
            
            Console.WriteLine("Would you like to add, subtract, multiply or divide? ");
            string operand = Console.ReadLine().ToLower();


            Console.WriteLine("Please enter two numbers, hitting enter after each ");
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());

            float total = 0;
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
            
            Console.WriteLine("The total is {0}", total);
      
        }
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
