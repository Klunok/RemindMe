
Console.Write("Here a text in console");
Console.WriteLine("Here a text in console and add a new line");

int wholeNumber = 123; // 4 bytes from -2,147,483,648 to 2,147,483,647
long doubleInteger = 123456L // 8 bytes  from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float floatingNumber = 100.111F // 4 bytes for storing 6 to 7 decimal digits
double floatingNumber = 100.111D; // 8 bytes for storing 15 decimal digits
char singleCharacter = a ;  // 2 bytes
string simpleText = "text"; // 2 bytes per character
bool TrueOrFalse = true; // 1 bytes

// Casting
// Implicit (auto) - char -> int -> long -> float -> double
// Explicit (manual) - double -> float -> long -> int -> char

Console.Read(); // to get info from terminal
Console.ReadLine(); // and add a new line

/* Operators
Adding +
Substraction -
Multiplication *
Division /
Modulus %
Increment ++
Decrement --
*/

int x = 10;
x += 5; // now x = 15 

 /* Comparison
 Equal ==
 Not Equal !=
 Greater >
 Less <
 Greater or equal >=
 Less or equal <=
 */

 /* Logical
Return True if both are true &&
Return True if one is tru ||
Reverse the result !
*/

string text = "just a text";
string concatenation = "text 1" + "text 2";
string conca = string.Concat(text1, text2);
string text = $"Multiply text: {text1} {text2}";
string text = "text with \" \" write like this and it\' okay or this \\";
/*
\n - New line
\t - Tab
\b - Backspace
*/


if (condition)
{True}
else 
{false}

variable = (condition) ? expressionTrue : expressionFalse;

switch(condition)
{
    case 1: 
    // result 1
    break;
    case 2:
    // result 2
    break;
}

