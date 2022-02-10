using System;

namespace learning_Visual_Studio {
    class Program {
        static void Main() {

            // BREAKPOINT EXAMPLE
            // ----------------------------------------------------------
            Console.WriteLine("BREAKPOINT example: ");
            int myVal = 50;
            Console.WriteLine(myVal);
            Console.WriteLine("");


            // ARITHMETIC EXAMPLE
            // ----------------------------------------------------------
            Console.WriteLine("ARITHMETIC example: ");
            int number1; int number2;
            int mySum, myProduct, myDifference, myQuotient;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            mySum = number1 + number2;
            myProduct = number1 * number2;
            myDifference = number1 - number2;
            myQuotient = number1 / number2;

            Console.WriteLine($"Sum = {mySum}");
            Console.WriteLine($"Product = {myProduct}");
            Console.WriteLine($"Difference = {myDifference}");
            Console.WriteLine($"Quotient = {myQuotient}");
            Console.WriteLine("");


            // OUTPUT EXAMPLE
            // ----------------------------------------------------------
            Console.WriteLine("OUTPUT Example: ");
            int num1=1; int num2=2; int num3 = 3; int num4 = 4;

            Console.WriteLine("1 2 3 4");

            Console.Write("1 ");
            Console.Write("2 ");
            Console.Write("3 ");
            Console.Write("4\n");

            Console.WriteLine($"{num1} {num2} {num3} {num4}");
            Console.WriteLine("");


            // MATH EXAMPLE
            // ----------------------------------------------------------
            Console.WriteLine("MATH Example: ");
            int radiusIN; double myPI = Math.PI;

            Console.Write("Enter the radius of a circle (integer): ");
            radiusIN = int.Parse(Console.ReadLine());

            Console.WriteLine($"Diameter: {(radiusIN * 2)}, Circumference: {((radiusIN * 2) * myPI)}, Area: {(myPI * (radiusIN * radiusIN))}");
            Console.WriteLine("");

        }
    }
}
