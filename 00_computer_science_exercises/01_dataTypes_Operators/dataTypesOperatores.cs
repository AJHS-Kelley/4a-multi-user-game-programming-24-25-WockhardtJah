// Data Types and Operators, Ja'Sher Douglas, v0.0
Using System;

class DataTypesOperators {
static void Main() {
    // This is a comment, it gets ignored.

    /*
    This is still a comment.
    */

    // DATA TYPES
    // C# is STATICALLY TYPED -- once a variable has a data type, it cannot change.

    // Float - float -- decimal numbers, +/- including 0.0
    // Double - double -- decimal numbers, +/-, including 0.0 <-- MOST COMMONLY USED DECIMAL
    // Integers -- int -- whole numbers, +/-, including 0

    // VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INISDE

    // DECLARING (CREATING VARIABLES)
    // Method #1 -- Declared But Not Assign
    // dataType VariableName;

    int myInteger;
    double myDouble; 

    // Method #2 -- Declare AND Assign
    int myInteger2 = 1;
    double myDouble2 = 2.05D;

    // Strings -- Collections of letters, numbers special characters.
    string myString = "This is my String.";

    // Boolean -- bool - True or False values.
    bool myBool = true;
    bool fireResitance = true;
    bool hasPurpleKey = false;

    // Character -- char -- a single character.
    char myChar = 'A';

    // ASSIGNING VALES AFTER DECLARATION
   
    myInteger =5;
    myDouble = -1.0D;

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    //Console.Writeline(myInteger);
    //Console.Writeline(myDouble);

    //PRINTING EXPRESSIONS TO THE CONSOLE TERMINAL
    //Console.Writeline(myInteger - 25);
    //.WriteLine(myDouble + 2.5D);


    // OPERATORS -- ARITHMETIC
    //Addition
    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;
    double myNewNumber = myInteger + myDouble;

    // SUBTRACTION
    myNewNumber = myDouble - myInteger;
   
    // DIVISION
    myNewNumber = myDouble / myInteger;

    // MULTIPLICATION
    myNewNumber = myDouble * myInteger;

    // MODULUS -- Divides, then returns the REMAINDER
    // Most commonly used to determine EVEN or ODD
    myNewNumber = myDouble % 2;

    int students = 6;
    int numSlices = 35;
    int leftOvers;

    leftOvers = numSlices % students;

    // Increment / Decrement -- Most frequently used in LOOPS
    int x =0;
    x++; // What is x equal to now?
    // Incremnt ++ adds 1 to the current value and puts the new value into the bucket
    x--;
    // Decrement -- subtracts 1 from the current value and puts the new value into the bucket

    // Special Assignment Operators
    x += 1;
    x -= 1;
    x /= 1;
    x -= 1;
    x *= 1;
    // Take current value, perform the calculation, put new value into bucket

    // COMPARISON OPERATORS
   // EVALUATE THE EXPRESSION, RETURN true OR false
   int y = 5;
   int z = 3;

   // IS-EQUAL-TO == is the value on the left equal to the right?
   // Console.Writeline (y == Z);

   // // NOT-EQUAL-TO != is the value on the left not equal to the right?
   // Console,WriteLine( y != z);

   // // GREATER Than >
   // Console.WriteLine(y > z);
   // // GTEATER THAN-OR-EQUAL-TO >=
   // Console.WriteLine( y >= z):
   // // LESS THAN <
  // Console. WriteLine(y < z);
  // // LESS THAN-OR- EQUAL-TO <=
  // Console. WriteLine (y <= z) ;

  // LOGICAL OPERATORS
  int b = 1;
  double c = 2.0D;
  string favColor = "Blue";
  // Logical AND && -- all statements must be True
  // Console. WriteLine(b › 1 && c != 5.0D); // false because b is not › 1
  // Console WriteLine(b == 1 && c < 10.0D); // both are true, whole expression is true
  // // If one expression most likely to be False, check for it FIRST!
  // Console WriteLine(hasPurpleKey == true && playerLevel › 5);
  // Console. WriteLine(hasPurpleKey == true && playerLevel › 5 && hasFlameThrower == true && timeRemaining › 99);

  // Logical OR -- ONE statement must be True
 // Console WriteLine(b › 1 || c != 5.0D); // true bc c is not equal to 5.0
 // Console WriteLine(b == 2 || c › 10.0D); // false be both expressions are false
 // // Check for the statement most likely to be true first!
 // Console WriteLine(hasBlueKey == true && playerLevel › 3);
 // Logical NOT ! -- Returns the opposite value of the expression.
 Console. WriteLine(b › -1); // True
 Console. WriteLine(!(b › -1)); // False
 }