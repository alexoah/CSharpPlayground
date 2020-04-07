/**
 *	from C# User Input: Exercise 2 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_user_input2 )
 *
 *	question:
 *	Fill in the missing parts to print a number put in by the user:
 *
 *	Console.WriteLine("Think of a number:");
 *	int myNum = Convert._______(Console.__________);
 *	Console.WriteLine("Your number is: " + myNum);
 *
 */
Console.WriteLine("Think of a number:");
int myNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Your number is: " + myNum);