using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("What is your message?");
		string input = Console.ReadLine();
		string choice = input.ToUpper();
		string message = choice;
		foreach (char c in choice)
        {
            Console.WriteLine(c);
        }
        for (int i = 0; i < choice.Length; i++)
        {
            Console.WriteLine(choice[i]);
        }
{
  Console.WriteLine(i);
}
        
		
	
	}
}