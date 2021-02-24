using System;

namespace ytTutorialGiraffe
{
    internal class OldProgram
    {
        private static void OldMain(string[] args)
        {
            //---------------- 2D ARRAYS --------------------------
            // each comma inside brackets adds dimensions
            // int[] - one dimension
            // int[,] - two dimensions
            // int[,,] - three dimensions
            // for example:
            // int[,] myArray = new int[2,3]; // We declare two collumns with 3 rows each
            int[,] numberGrid = {
                {1,2 },
                {3,4 },
                {5,6 }
            };

            Console.WriteLine(numberGrid[1, 1]);

            //------------------- EXCEPTION HANDLING ---------------
            try
            {
                Console.Write("Enter first number: ");
                int numFirst = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int numSecond = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numFirst / numSecond);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            /*catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }*/
            /*finally
            {
                // everything here will be executed even if error happened
            }*/

            //------------------- SIMPLE CALCULATOR ---------------
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            }
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }

            Console.ReadLine();
        }
    }
}