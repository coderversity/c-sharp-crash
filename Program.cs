using c_sharp_crash;

// Outputting to cnsole followed by a new line
Console.WriteLine("Hello, world!");

// Output to console without a trailing new line
Console.Write("My name is Ron.");
Console.WriteLine("I am a software developer");

/*
 * DATA TYPES
 */
// assigning a value to a variable
int num = 4;
Console.WriteLine(num);

// you can also declare variables without assigning a value
string name;
name = "Ron";
Console.WriteLine(name);

// strings
string text = "Welcome to C#!";
Console.WriteLine(text);

// char (use single quotes)
char letter = 't';
Console.WriteLine(letter);

// type coercion - forcing a char to become a string data type
string str = "" + letter;
str = str + "ea";
Console.WriteLine(str);

// using the ToString() function
char letter2 = 'Y';
string letter2AsStr = letter2.ToString();
Console.WriteLine(letter2AsStr + " is a " + letter2AsStr.GetType());


// integers (whole numbers)
int x = 5;
int y = 10;
Console.WriteLine(x + y);

// integers can be negative too
int a = -25;
int b = -4;
Console.WriteLine(a * b);

// floats (single-digit precision)
float num1 = 2.5f;
float num2 = 35.6f;
Console.WriteLine(num1 + num2);

// doubles (stores flatoing point numbers with decimals)
double c = 242.4290900940904;
double d = 33.33389849898;
Console.WriteLine(c + d);

// decimals (for more fine-tuning of decimal values. Generally used for money values)
decimal e = (Decimal) c;
decimal f = (Decimal) d;
Console.WriteLine(e + f);

// booleans (true or false)
bool isSunny = true;
Console.WriteLine(isSunny);

// Date and Time
DateTime currentDate = DateTime.Now;
Console.WriteLine(currentDate);

// Date only (two ways)
// as datetime value (will just set time to 12:00 AM UTC)
DateTime dateOnly = currentDate.Date;
Console.WriteLine(dateOnly);

// or, convert to string and truncate the time
string dateAsStr = currentDate.ToString("yyyy-MM-dd");
Console.WriteLine(dateAsStr);

// get future date and time
DateTime tomorrow = currentDate.AddDays(1);
Console.WriteLine(tomorrow);

// get past date and time
DateTime yesterday = currentDate.AddDays(-1);
Console.WriteLine(yesterday);

// enumerators (enums) - used to define named integer constants
//Console.WriteLine(DaysOfWeek.Wednesday);

//enum DaysOfWeek
//{
//    Sunday,
//    Monday,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday
//}

/**
 * ARRAYS
 */
// Arrays allow you to store multiple values of the same data type
int[] numbers = { 1, 2, 3, 4, 5 };
Console.WriteLine($"Position 0: {numbers[0]}, Position 2: {numbers[2]}");

// defining an array with a pre-determined number of indexes
string[] people = new string[2];
people[0] = "Bob";
people[1] = "Jane";
Console.WriteLine(people.Length);


// an error if we try to add another person to the people array
try
{
    people[2] = "John";
} catch (Exception exc)
{
    Console.WriteLine($"An error occurred: {exc}");
}

// Object as a data type to hold ANY value
Object obj1 = 2;
Object obj2 = DateTime.Now;
Console.WriteLine($"{obj1} is a {obj1.GetType()}");
Console.WriteLine($"{obj2} is a {obj2.GetType()}");

// you can also have an array of Object data types
Object[] objArray = { obj1, obj2, "This is a string" };
Console.WriteLine(objArray[2]);

/**
 * NULLABLE DATA TYPES
 */
// We can set a value as nullable if we believe that the value may have a null value
int? age = null;
Console.WriteLine($"Age: {age}");
age = 24;
Console.WriteLine($"Age: {age}");

/**
 * CLASSES AND STRUCTS
 */
// Classes and structs are like custom data types that you can create to define behavior and state.

// Classes
Person person = new Person();
person.Name = "Katie";
person.Age = 42;
Console.WriteLine(person.Age);