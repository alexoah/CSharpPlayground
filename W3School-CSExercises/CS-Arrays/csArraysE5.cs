/**
 *	from C# Arrays: Exercise 5 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_arrays5 )
 *
 *	question:
 *	Use the correct method to sort the cars array.
 *
 *	string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
 *	_____.____(____);
 *	foreach (string i in cars)
 *	{
 *		Console.WriteLine(i);
 *	}
 *
 */
string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
Array.Sort(cars);
foreach (string i in cars)
{
	Console.WriteLine(i);
}