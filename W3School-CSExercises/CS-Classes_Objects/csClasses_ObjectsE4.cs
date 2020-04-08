/**
 *	from C# Classes/Objects: Exercise 4 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_classes4 )
 *
 *	question:
 *	Call the fullThrottle() method from the object:
 *
 *	class Car 
 *	{
 *		public void fullThrottle()
 *		{
 *			Console.WriteLine("The car is going as fast as it can!"); 
 *		}
 *
 *		static void Main(string[] args)
 *		{
 *			Car myObj = new Car();
 *			_____._______________
 *		}
 *	}
 *
 */
class Car 
{
	public void fullThrottle()
	{
		Console.WriteLine("The car is going as fast as it can!"); 
	}

	static void Main(string[] args)
	{
		Car myObj = new Car();
		myObj.fullThrottle();
	}
}