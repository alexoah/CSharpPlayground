/**
 *	from C# Methods: Exercise 3 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_methods3 )
 *
 *	question:
 *	Add a fname parameter of type string to MyMethod.
 *
 *	static void MyMethod(______ _____)
 *	{
 *		Console.WriteLine(fname + " Refsnes");
 *	}
 *
 *	static void Main(string[] args)
 *	{
 *		MyMethod("Liam");
 *		MyMethod("Jenny");
 *		MyMethod("Anja");
 *	}
 *
 */
static void MyMethod(string fname) 
{
	Console.WriteLine(fname + " Refsnes");
}

static void Main(string[] args)
{
	MyMethod("Liam");
	MyMethod("Jenny");
	MyMethod("Anja");
}