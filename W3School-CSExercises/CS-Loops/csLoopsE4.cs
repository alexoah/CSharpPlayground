/**
 *	from C# Loops: Exercise 4 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_while_loop4 )
 *
 *	question:
 *	Stop the loop if i is 5.
 *
 *	for (int i = 0; i < 10; i++) 
 *	{
 *		if (i == 5) 
 *		{
 *			_____;
 *		}
 *		Console.WriteLine(i);
 *	}
 *
 */
for (int i = 0; i < 10; i++) 
{
	if (i == 5) 
	{
		break;
	}
	Console.WriteLine(i);
}