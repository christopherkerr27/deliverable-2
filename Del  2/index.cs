using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("What is your message?");
		string input = Console.ReadLine();
		input = input.ToUpper();
		int checksum = 0;
		string message = "";
		foreach (char letter in input)
		{
			string messageLetter = (Convert.ToInt32(letter) - 64).ToString();
			message = message + messageLetter + "-";
			var str = messageLetter;
			checksum = checksum + (Convert.ToInt32(letter) - 64);
		}

		Console.WriteLine("Encoded message is " + message);
		Console.WriteLine("The checksum is " + checksum);
	}
}