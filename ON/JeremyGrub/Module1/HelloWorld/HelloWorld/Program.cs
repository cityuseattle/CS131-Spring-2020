// 'using' includes an existing code library (namespace)
using System;

// namespace is a logical group of classes
namespace HelloWorld
{

	// Classes provide logical groupings of data and method routines
	class Program
	{
		/* -Methods group instructions to complete a task
		   -C# console applications begin in the Main() method*/ 
		static void Main(string[] args)
		{
			// Variables reference data in the program
			// The variable named 'output' is declared as a text string
			// The variable is initialized with the value 'Hello World!'
			string output = "Hello World!";
			Console.WriteLine(output);
			Console.ReadLine();
		 }
	}
}
