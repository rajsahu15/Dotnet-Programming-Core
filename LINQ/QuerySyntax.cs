using System;
using System.Linq;

public class QuerySyntax
{
	static void Main(string[] args)
	{

		int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
		var a = from i in arr where i > 5 orderby i ascending select i;

		foreach (var value in a)
		{
			Console.Write(value + " ");
		}

		//method Syntax

		var b=arr.Where(i => i > 5)
		   .OrderByDescending(i => i)
		   .ToList();

		foreach (var value in b) {
			
			Console.Write(value + " ");

		}
	}
}