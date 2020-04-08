/**
 *	from C# If...Else: Exercise 4 ( https://www.w3schools.com/cs/exercise.asp?filename=exercise_conditions4 )
 *
 *	question:
 *	Print "1" if x is equal to y, print "2" if x is greater than y, otherwise print "3".
 *
 *	int x = 50;
 *	int y = 50;
 *	__ (x __ y) 
 *	{
 *	  Console.WriteLine("1");
 *	} 
 *	_______ (x _ y) 
 *	{
 *	  Console.WriteLine("2");
 *	} 
 *	____
 *	{
 *	  Console.WriteLine("3");
 *	}
 *
 */
int x = 50;
int y = 50;
if (x == y) 
{
  Console.WriteLine("1");
} 
else if (x > y) 
{
  Console.WriteLine("2");
} 
else
{
  Console.WriteLine("3");
}