/**
 *	from C# Classes/Objects: Exercise 5 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_classes5 )
 *
 *	question:
 *	Create a constructor of Car, and call it:
 *
 *	class Car
 *	{
 *		public string model;
 *		______ _____
 *		{
 *			model = "Mustang";
 *		}
 *
 *		static void Main(string[] args)
 *		{
 *			___ Ford = ___ ______
 *			Console.WriteLine(Ford.model);
 *		}
 *	}
 *
 */
class Car
{
	public string model;
	public Car()
	{
		model = "Mustang";
	}

	static void Main(string[] args)
	{
		Car Ford = new Car();
		Console.WriteLine(Ford.model);
	}
}