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

// Declaring a string variable, stored text data in multiple bytes
//string stringVar = "Hello, World!";

// Declaring a boolean variable, stored true/false values in 1 byte
//bool boolVar = true;

// Declaring a floating-point variable, stored numbers with decimals in 4 bytes
//float floatVar = 3.14f;

// Declaring a double variable, stored numbers with decimals in 8 bytes
//double doubleVar = 3.14159;

// Declaring a character variable, stored single 16-bit Unicode characters in 2 bytes
//char charVar = 'A';

// Declaring a decimal variable, stored high-precision decimal numbers in 16 bytes
//decimal decimalVar = 19.99m;

// Declaring a constant variable, value cannot be changed after initialization
//const double Pi = 3.14159;


////TYPE CASTING
// Implicit casting (automatically done by the compiler)
//int intVar = 10;
//double doubleVar = intVar; // int to double

// Explicit casting (manually done by the programmer)
//double doubleVar = 9.78;
//int intVar = (int)doubleVar; // double to int

// Using Convert class for type conversion
//string strNum = "123";
//int intNum = Convert.ToInt32(strNum);

// Using Parse method for type conversion
//string strNum = "456";
//int intNum = int.Parse(strNum);

// Using TryParse method for safe type conversion
//string strNum = "789";
//int intNum;
//bool success = int.TryParse(strNum, out intNum);
