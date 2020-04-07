/**
 *	from C# Strings: Exercise 3 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_strings3 )
 *
 *	question:
 *	Use the string interpolation method to concatenate two strings:
 *
 *	string firstName = "John";
 *	string lastName = "Doe";
 *	string name = _"My full name is: ___________ __________";
 *	Console.WriteLine(name);
 *
 */
string firstName = "John";
string lastName = "Doe";
string name = $"My full name is: {firstName} {lastName}";
Console.WriteLine(name);