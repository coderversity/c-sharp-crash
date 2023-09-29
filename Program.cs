using System;

/**
 * HELLO WORLD APPLICASTION
 */
class Program
{
    static void Main()
    {
        PrintToConsole();
        VariablesAndDataTypes();
        MathOperators();
        ComparisonOperators();
    }

    private static void PrintToConsole()
    {
        Console.WriteLine("Hello, World!");
    }

    private static void VariablesAndDataTypes()
    {
        // Integer (whole number)
        int age = 30;
        Console.WriteLine(age);

        // Floating point number with single-digit precision
        // Use 'f' to specify a float literal
        float price = 19.99f;
        Console.WriteLine(price);

        // Floating point number with Double-digit precision floating point number
        double interest = 5.52;
        Console.WriteLine(interest);

        // for the most accurate rounding, use decimal instead of double (best used for money values)
        decimal accountBalance = 3424.45M;
        Console.WriteLine($"Your account balance is {accountBalance}");

        // Character
        char grade = 'A';
        Console.WriteLine($"Your overall grade this semester: {grade}");

        // Strings are text values that usually contain one or more characters. THey are immutable objects,
        // which means that we cannot change them. Every "change" will create a new string object in memory.
        string name = "Ron";
        Console.WriteLine($"Hi, my name is {name}");

        // Booleans are true or false values
        bool isStudent = true;
        Console.WriteLine(isStudent);

        // Variables can also be declared without initialization
        int quantity;
        string product;

        // Assigning values to previously declared variables
        quantity = 4;
        product = "apples";
        Console.WriteLine($"There are {quantity} {product} on sale.");

        // Constants are read-only values that cannot be changed
        const double Pi = 3.14159265359;
        Console.WriteLine($"Value of PI: {Pi}");

        // If we try to change Pi, we'll get an error message
        //Pi = 0;
    }


    private static void MathOperators()
    {
        int num1 = 10;
        int num2 = 5;

        int addition = num1 + num2;    // Addition: 10 + 5 = 15
        Console.WriteLine("Addition: " + addition);

        int subtraction = num1 - num2; // Subtraction: 10 - 5 = 5
        Console.WriteLine("Subtraction: " + subtraction);

        int multiplication = num1 * num2; // Multiplication: 10 * 5 = 50
        Console.WriteLine("Multiplication: " + multiplication);

        int division = num1 / num2;      // Division: 10 / 5 = 2
        Console.WriteLine("Division: " + division);


        // The following will cause a Divide by Zero exception. Use a try/catch block to handle these (see exception handling below)
        int num3 = 5;
        int num4 = 0;

        try
        {
            division = num3 / num4;
            Console.WriteLine(division);
        } catch (DivideByZeroException ex)
        {
            Console.WriteLine("An error occurred: " + ex.ToString());
        }

        int modulus = num1 % num2;       // Modulus (remainder of 0): 10 % 5 = 0
        Console.WriteLine("Modulus: " + modulus);

        modulus = 11 % 2;       // Modulus (remainder of 1): 11 % 5 = 1
        Console.WriteLine("Modulus: " + modulus);
    }

    private static void ComparisonOperators()
    {
        int a = 10;
        int b = 5;

        bool isEqual = (a == b);    // Equal to: false
        Console.WriteLine("Numbers equal? " + isEqual);

        bool isNotEqual = (a != b); // Not equal to: true
        Console.WriteLine("Numbers not equal? " + isNotEqual);

        bool isGreater = (a > b);   // Greater than: true
        Console.WriteLine("Is A greater than B? " + isGreater);

        bool isLess = (a < b);      // Less than: false
        Console.WriteLine("Is A less than B? " + isLess);

        bool isGreaterOrEqual = (a >= b); // Greater than or equal to: true
        Console.WriteLine("Is A greater than or equal to B? " + isGreaterOrEqual);

        bool isLessOrEqual = (a <= b);    // Less than or equal to: false
        Console.WriteLine("Is A less than or equal to B? " + isLessOrEqual);
    }
}