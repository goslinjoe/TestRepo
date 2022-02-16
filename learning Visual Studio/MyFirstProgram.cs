// NAMESPACES, collections of predefined classes related to some common functionality
using System;

// namespace learning_Visual_Studio {
    
    // every app contains at least one user-defined class (each word in the class name begins with a capital letter [camel case])...
    // the .cs file name is usually this first class name followed by ".cs"

    class MyFirstProgram 
    {

        // ENTRY POINT, the "Main" method (parentheses indicate this is a method)
        // "void" means this method will NOT return a value when it's done
        static void Main() 
        {

            // objects are instances of a class (the blueprint for the object), and can contain ATTRIBUTES (name, color, size, etc) and BEHAVIORS (a set of methods for performing tasks)
            // objects have "accessors" (get and set) for those properties we want to be able to interface with (other attributes may be "internal" only)

            // new classes can be made by "inheriting" existing class models, and then personalizing some aspect(s) of the new class (example: a convertible class can be made by inheriting a car class)

            // Unified Modeling Language (UML) is a graphical scheme for blueprinting/summarizing the attributes and operations related to the requirements and design decisions of a given project

            // .NET Framework = a collection of standard prebuilt classes (I/O, db, networking, mobile, file access, web comm, etc) that help a developer build quickly (and avoid re-inventing the wheel)

            // VisualStudio "apps" -- built from "solutions" -- built from "projects"
            // File > New > Project ...Installed > Templates > Visual C# ...Windows > Console Application

            // TYPES: string, bool, byte, sbyte, char, short, ushort, int, uint, long, ulong, float, double, decimal


            // BREAKPOINT EXAMPLE
            // ----------------------------------------------------------
            //            Console.WriteLine("BREAKPOINT example: ");
            //            int myVal = 50;
            //            Console.WriteLine(myVal);
            //            Console.WriteLine("");


            // ARITHMETIC EXAMPLE
            // ----------------------------------------------------------
            //            Console.WriteLine("ARITHMETIC example: ");
            //            int number1; int number2;
            //            int mySum, myProduct, myDifference, myQuotient;  // variables defined with their name and a TYPE

            //            Console.Write("Enter first integer: ");
            //            number1 = int.Parse(Console.ReadLine());  // Parse converts strings to a number (int, in this case)

            //            Console.Write("Enter second integer: ");
            //            number2 = int.Parse(Console.ReadLine());

            //            mySum = number1 + number2; 
            //            myProduct = number1 * number2;
            //            myDifference = number1 - number2;
            //            myQuotient = number1 / number2;

            //            Console.WriteLine($"Sum = {mySum}");  // INTERPOLATED STRING, starts with a $ symbol and then "interpolates" the bracketed expression as part of the overall string
            //            Console.WriteLine($"Product = {myProduct}");
            //            Console.WriteLine($"Difference = {myDifference}");
            //            Console.WriteLine($"Quotient = {myQuotient}");
            //            Console.WriteLine("");


            // OUTPUT EXAMPLE
            // ----------------------------------------------------------
            //            Console.WriteLine("OUTPUT Example: ");
            //            int num1=1; int num2=2; int num3 = 3; int num4 = 4;

            //            Console.WriteLine("1 2 3 4");

            //            Console.Write("1 ");
            //            Console.Write("2 ");
            //            Console.Write("3 ");
            //            Console.Write("4\n");

            //            Console.WriteLine($"{num1} {num2} {num3} {num4}");
            //            Console.WriteLine("");


            // MATH EXAMPLE
            // ----------------------------------------------------------
            //            Console.WriteLine("MATH Example: ");
            //            int radiusIN; double myPI = Math.PI;

            //            Console.Write("Enter the radius of a circle (integer): ");
            //            radiusIN = int.Parse(Console.ReadLine());

            //            Console.WriteLine($"Diameter: {(radiusIN * 2)}, Circumference: {((radiusIN * 2) * myPI)}, Area: {(myPI * (radiusIN * radiusIN))}");
            //            Console.WriteLine("");


            // BANK ACCOUNT (Chapter 4)
            // class properties: Name, Blanace
            // class methods: Deposit, Withdraw
            // ----------------------------------------------------------
            BankAccount myAccount = new BankAccount();  // "new" is an object-creation expression, and the Type ("Account") should match the class we're instantiating
            Console.WriteLine($"Initial name is: {myAccount.GetName()}");  // Account has a method called "GetName", so the new object "myAccount" will hve this as well
            Console.WriteLine($"Initial name is: {myAccount.Name}");  // an accessor PROPERTY called "Name" (uppercase), that acts like the GetName method

            Console.Write("Enter the name: ");
            string theName = Console.ReadLine();
            myAccount.SetName(theName);
            myAccount.Name = theName;  // uses the SET ACCESSOR to update the value of the "Name" PROPERTY, in the same way that the SetName method updated our object's instance variable "name" (lowercase)

            Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");
            Console.WriteLine($"myAccount's name is: {myAccount.Name}");  // we're doing everything two ways here, to show method calls versus property ACCESSOR calls
            Console.WriteLine("");


            // Hit any key...
            // ----------------------------------------------------------
            Console.WriteLine("PRESS <ENTER> TO QUIT");
            Console.ReadLine();
        }

    }

// }
