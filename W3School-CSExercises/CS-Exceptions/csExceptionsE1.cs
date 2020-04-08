/**
 *	from C# Exceptions: Exercise 1 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_exceptions1 )
 *
 *	question:
 *	Fill in the missing parts to output an error message if an error occurs.
 *
 *	___
 *	{
 *		int[] myNumbers = {1, 2, 3};
 *		Console.WriteLine(myNumbers[10]);
 *	}
 *	_____ (Exception e)
 *	{
 *		Console.WriteLine(e.Message);
 *	}
 *
 */
try
{
	int[] myNumbers = {1, 2, 3};
	Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}