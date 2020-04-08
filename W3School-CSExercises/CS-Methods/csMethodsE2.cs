/**
 *	from C# Methods: Exercise 2 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_methods2 )
 *
 *	question:
 *	Insert the missing parts to call MyMethod two times.
 *
 *	static void MyMethod() 
 *	{
 *		Console.WriteLine("I just got executed!");
 *	}
 *
 *	static void Main(string[] args)
 *	{
 *		___________
 *		___________
 *	}
 *
 */
static void MyMethod() 
{
	Console.WriteLine("I just got executed!");
}

static void Main(string[] args)
{
	MyMethod();
	MyMethod();
}