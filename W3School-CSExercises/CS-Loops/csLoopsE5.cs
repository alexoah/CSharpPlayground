/**
 *	from C# Loops: Exercise 5 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_while_loop5 )
 *
 *	question:
 *	In the following loop, when the value is "4", jump directly to the next value.
 *
 *	for (int i = 0; i < 10; i++) 
 *	{
 *		if (i == 4) 
 *		{
 *			________;
 *		}
 *		Console.WriteLine(i);
 *	}
 *
 */
for (int i = 0; i < 10; i++) 
{
	if (i == 4) 
	{
		continue;
	}
	Console.WriteLine(i);
}