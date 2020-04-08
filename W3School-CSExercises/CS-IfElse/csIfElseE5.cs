/**
 *	from C# If...Else: Exercise 5 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_conditions5 )
 *
 *	question:
 *	Insert the missing parts to complete the following "short hand if...else statement" (ternary operator):
 *
 *	int time = 20;
 *	string result = _time < 18_ _ "Good day." _ "Good evening.";
 *	Console.WriteLine(result);
 *
 */
int time = 20;
string result = (time < 18) ? "Good day." : "Good evening.";
Console.WriteLine(result);