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
        LogicalOperators();
        ConditionalStatements();
        Loops();
        Arrays();
        Collections();
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

    private static void LogicalOperators()
    {
        bool x = true;
        bool y = false;

        bool andResult = x && y; // Logical AND: false
        Console.WriteLine("X and Y: " + andResult);

        bool orResult = x || y;  // Logical OR: true
        Console.WriteLine("X or Y: " + orResult);

        bool notResult = !x;     // Logical NOT (inverts boolean values): false
        Console.WriteLine("Inverse of x: " + notResult);
    }

    private static void ConditionalStatements()
    {
        /**
         * IF-ELSE STATEMENTS
         */
        int age = 25;

        if (age < 18)
        {
            Console.WriteLine("You are a minor.");
        }
        else if (age >= 18 && age < 65)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a senior citizen.");
        }

        /**
         * SWITCH STATEMENTS
         */
        int day = 3;
        string dayName;

        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            default:
                dayName = "Weekend";
                break;
        }

        Console.WriteLine("Today is " + dayName);
    }

    private static void Arrays()
    {
        // Declare an array with pre-determined number of indexes
        int[] numbers = new int[5];

        // Initialize elements of the array
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;
        numbers[3] = 4;
        numbers[4] = 5;

        Console.WriteLine("The first number in the array is " + numbers[0]);
        Console.WriteLine("The fourth number in the array is " + numbers[3]);

        // Get number of items in array
        Console.WriteLine("Amount of numbers in array: " + numbers.Length);

        // Declare an array with shorthand and no pre-determined number of indexes
        string[] names =
        {
            "Bobby", "Katie", "Joseph", "Barbara", "Jimmy"
        };

        Console.WriteLine("The last name in the array is: " + names[names.Length - 1]);
    }

    private static void Collections()
    {
        // Lists are like dynamic arrays that can store elements of a specified type (T)
        // Lists can contain duplicate values
        List<string> cities = new List<string>();

        // add items to List
        cities.Add("New York");
        cities.Add("Tokyo");
        Console.WriteLine("First city: " + cities[0]);
        Console.WriteLine("Secondy city: " + cities[1]);
        Console.WriteLine("Number of cities in list: " + cities.Count);

        // Looping through a List with a foreach loop
        foreach (string city in cities)
        {
            Console.WriteLine("City: " + city);
        }
        

        // Dictionaries contain key-value pairs. The keys are used to index a particular entry and they are unique.
        // Values can be duplicated between entries.

        Dictionary<string, int> ageDict = new Dictionary<string, int>();
        string dictKey = "Alice";
        ageDict[dictKey] = 30;

        // Now get the dictionary entry
        if (ageDict.ContainsKey(dictKey))
        {
            Console.WriteLine($"{dictKey}'s age: {ageDict[dictKey]}");
        }

        // Loop through dictionary entries
        foreach (var entry in ageDict)
        {
            // get key
            Console.WriteLine("Key: " + entry.Key);
            Console.WriteLine("Value: " + entry.Value);
        }

        // Hashsets store only unique values (no duplicates)
        HashSet<string> names = new HashSet<string>();
        names.Add("Ron");
        names.Add("Tommy");
        names.Add("Tommy"); // Duplicate, won't be added

        // Loop through HashSet
        foreach (string name in names)
        {
            Console.WriteLine("Name in hashset: " + name);
        }

        // Queues are First-In / Frst-Out collections (FIFO). The first entry to be added to a Queue will
        // be the first one to be removed.
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        while (queue.Count > 0)
        {
            string item = queue.Dequeue();
            Console.WriteLine(item);
        }
    }

    private static void Loops()
    {
        // For-loop continues to iterate until the condition is met
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("For-loop count " + i);
        }

        // While-loop is used when you don't want to specify a condition beforehand. The loop will continue to iterate
        // unless a condition (which is specified within the loop block) is met.
        int count = 0;

        while (count < 3)
        {
            Console.WriteLine("While-loop count: " + count);
            count++; // VERY IMPORTANT: make sure to increment or decrement a counter to prevent infinite loops
        }

        // Do-while-loops (unlike while-loops) are guaranteed to run at least once. Use this loop if you don't want to specify
        // the condition beforehand, but want the loop to execute the code block AT LEAST ONCE.
        int num = 1;

        do
        {
            Console.WriteLine("Do-while-loop count: " + num);
            num++;
        } while (num <= 3);

        // FOR-EACH LOOPS
        // For-each loops are generally used with collection types, and they continue to iterate until the loop reaches the end of
        // the collection.

        // Foreach loop with array
        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            Console.WriteLine("Number: " + number);
        }
    }
}