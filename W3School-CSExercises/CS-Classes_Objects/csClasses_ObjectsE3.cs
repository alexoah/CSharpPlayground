/**
 *	from C# Classes/Objects: Exercise 3 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_classes3 )
 *
 *	question:
 *	Create an object of Car called myObj, and use it to set the value of maxSpeed to 200.
 *
 *	class Car 
 *	{
 *		int maxSpeed;
 *
 *		static void Main(string[] args)
 *		{
 *			___ _____ = ___ ___();
 *			_____.________ = ___;
 *			Console.WriteLine(myObj.color);
 *			Console.WriteLine(myObj.maxSpeed);
 *		}
 *	}
 *
 */
class Car 
{
	int maxSpeed;

	static void Main(string[] args)
	{
		Car myObj = new Car();
		myObj.maxSpeed = 200;
		Console.WriteLine(myObj.color);
		Console.WriteLine(myObj.maxSpeed);
	}
}