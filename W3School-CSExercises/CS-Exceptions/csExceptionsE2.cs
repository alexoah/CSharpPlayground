/**
 *	from C# Exceptions: Exercise 2 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_exceptions2 )
 *
 *	question:
 *	Fill in the missing parts to execute some code, after the exception statements, regardless of the result.
 *
 *	___
 *	{
 *		int[] myNumbers = {1, 2, 3};
 *		Console.WriteLine(myNumbers[10]);
 *	}
 *	_____ (Exception e)
 *	{
 *		Console.WriteLine("Something went wrong.");
 *	}
 *	_______
 *	{
 *		Console.WriteLine("The 'try catch' is finished.");
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
	Console.WriteLine("Something went wrong.");
}
finally
{
	Console.WriteLine("The 'try catch' is finished.");
}