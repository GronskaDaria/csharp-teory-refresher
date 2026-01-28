//// ESCAPE SEQUENCES:
// This C# code snippet demonstrates various language features and constructs.
// \a - Alert (bell) character
// \b - Backspace
// \f - Form feed
// \n - New line
// \r - Carriage return
// \t - Horizontal tab
// \v - Vertical tab
// \' - Single quote
// \" - Double quote
// \\ - Backslash

////VARIABLE DECLARATION AND DATA TYPES
// Declaring an integer variable, stored numbers in 4 bytes
//int integerVar = 42;
//
// Declaring a string variable, stored text data in multiple bytes
//string stringVar = "Hello, World!";
//
// Declaring a boolean variable, stored true/false values in 1 byte
//bool boolVar = true;
//
// Declaring a floating-point variable, stored numbers with decimals in 4 bytes
//float floatVar = 3.14f;
//
// Declaring a double variable, stored numbers with decimals in 8 bytes
//double doubleVar = 3.14159;
//
// Declaring a character variable, stored single 16-bit Unicode characters in 2 bytes
//char charVar = 'A';
//
// Declaring a decimal variable, stored high-precision decimal numbers in 16 bytes
//decimal decimalVar = 19.99m;
//
// Declaring a constant variable, value cannot be changed after initialization
//const double Pi = 3.14159;


////TYPE CASTING
// Implicit casting (automatically done by the compiler)
//int intVar = 10;
//double doubleVar = intVar; // int to double
//
// Explicit casting (manually done by the programmer)
//double doubleVar = 9.78;
//int intVar = (int)doubleVar; // double to int
//
// Using Convert class for type conversion
//string strNum = "123";
//int intNum = Convert.ToInt32(strNum);
//
// Using Parse method for type conversion
//string strNum = "456";
//int intNum = int.Parse(strNum);
//
// Using TryParse method for safe type conversion
//string strNum = "789";
//int intNum;
//bool success = int.TryParse(strNum, out intNum);


////ARYSMETIC OPERATORS
// Addition
//int sum = 5 + 3; // sum = 8
//
// Subtraction
//int difference = 5 - 3; // difference = 2
//
// Multiplication
//int product = 5 * 3; // product = 15
//
// Division
//int quotient = 5 / 3; // quotient = 1
//
// Modulus 
//int remainder = 5 % 3; // remainder = 2
//
// Increment
//int count = 5;
//count++; // count = 6
//
// Decrement
//int count = 5;
//count--; // count = 4

////CONTROL FLOW STATEMENTS
// If statement is used to execute a block of code if a specified condition is true.
// If-else statement
//if (number > 0) {
//    Console.WriteLine("The number is positive.");}
//else {
//    Console.WriteLine("The number is not positive."); }
//
// Switch statement is used to select one of many code blocks to be executed.
//switch (day)
//   { case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    default:
//        Console.WriteLine("Other day");
//        break;    }
//
// For loop is used to execute a block of code a specified number of times.
//for (int i = 0; i < 5; i++)
//   { Console.WriteLine("Iteration: " + i); }
//
// While loop is used to execute a block of code as long as a specified condition is true.
//int i = 0;
//while (i < 5)
//
//    {Console.WriteLine("Iteration: " + i);
//    i++;}
//
// Do-while loop is similar to while loop, but it executes the block of code at least once.
//int i = 0;
//do
//  {    Console.WriteLine("Iteration: " + i);
//    i++;
//  }  while (i < 5);


////LOGICAL OPERATORS 
////check if more than one condition is true or false
///
// AND operator (&&) - returns true if both operands are true
//bool result = (5 > 3) && (2 < 4); // result = true
//
// OR operator (||) - returns true if at least one operand is true
//bool result = (5 > 3) || (2 > 4); // result = true
//
// NOT operator (!) - returns true if the operand is false
//bool result = !(5 > 3); // result = false


////ARRAYS is a collection of items stored at contiguous memory locations
// Declaring and initializing an array of integers
//int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
//
// Accessing array elements
//int firstNumber = numbers[0]; // firstNumber = 1
//int secondNumber = numbers[1]; // secondNumber = 2
//
// Modifying array elements
//numbers[2] = 10; // numbers = { 1, 2, 10, 4, 5 }
//
// Getting the length of the array
//int length = numbers.Length; // length = 5


////METHODS is a block of code that performs a specific task. Reusable code
// Defining a method that adds two integers and returns the result  
//int Add(int a, int b)
//{   return a + b; }
//
// Calling the Add method
//int sum = Add(5, 3); // sum = 8

////CLASSES AND OBJECTS
// class is a blueprint for creating objects
// object is an instance of a class


////OVERLOADING AND OVERRIDING
// Method Overloading: same method name with different parameters
// Method Overriding: derived class provides specific implementation of a method in base class

////EXCEPTION HANDLING
// try-catch block to handle exceptions
//try is used to enclose code that may throw an exception
//catch is used to handle the exception
//finaly is used to execute code regardless of whether an exception occurred or not





