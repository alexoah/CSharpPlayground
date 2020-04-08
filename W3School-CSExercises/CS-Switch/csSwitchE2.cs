/**
 *	from C# Switch: Exercise 2 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_switch2 )
 *
 *	question:
 *	Complete the switch statement, and add the correct keyword at the end to specify some code to run if there is no case match in the switch statement.
 *
 *	int day = 3;
 *	switch (___)
 *	{
 *		____ 1:
 *			Console.WriteLine("Today is Saturday");
 *			break;
 *		____ 2:
 *			Console.WriteLine("Today is Sunday");
 *			_____;
 *		_______:
 *			Console.WriteLine("Looking forward to the Weekend");
 *			_____;
 *	}
 *
 */
int day = 3;
switch (day) 
{
	case 1:
		Console.WriteLine("Today is Saturday");
		break;
	case 2:
		Console.WriteLine("Today is Sunday");
		break;
	default:
		Console.WriteLine("Looking forward to the Weekend");
		break;
}