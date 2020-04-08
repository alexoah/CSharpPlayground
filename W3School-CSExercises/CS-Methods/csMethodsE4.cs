/**
 *	from C# Methods: Exercise 4 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_methods4 )
 *
 *	question:
 *	Insert the missing part to print the number 8 in Main, by using a specific keyword inside MyMethod:
 *
 *	static int MyMethod(int x) 
 *	{
 *		______ 5 + x;
 *	}
 *
 *	static void Main(string[] args)
 *	{
 *		Console.WriteLine(MyMethod(3));
 *	}
 *
 */
static int MyMethod(int x) 
{
	return 5 + x;
}

static void Main(string[] args)
{
	Console.WriteLine(MyMethod(3));
}