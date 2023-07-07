using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		
			public static bool IsAPalindrome(string word)
			{
			string reversedWord = "";
			for (int i = word.Length-1; i >= 0; i++)
			{

				reversedWord += word;

			}

			return word.ToLower() == reversedWord.ToLower();
			
			}



		
	}
}

