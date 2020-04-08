/**
 *	from C# Loops: Exercise 2 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_while_loop2 )
 *
 *	question:
 *	Use the do/while loop to print i as long as i is less than 6.
 *
 *	int i = 1;
 *	__
 *	{
 *		Console.WriteLine(i);
 *		___;
 *	}
 *	_____ (i _ 6);
 *
 */
int i = 1;
do 
{
	Console.WriteLine(i);
	i++;
}
while (i < 6);