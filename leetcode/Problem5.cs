/*
 * =================================================
 * Description:
 *  https://leetcode.com/problems/longest-palindromic-substring/
 * =================================================
 * Project:   leetcode
 * Developer: Alex Huot - huot.alex@gmail.com
 * Company:   Algorilla Inc.
 * Github:    https://github.com/Algorilla
 * 
 * Copyright  Algorilla Inc. - 2020
 * =================================================
 */

public class Problem5 
{
	public string LongestPalindrome(string s) 
	{
		// First inclination is to use a stack, but need a way to detect when to begin popping for comparison
		//
		// Thinking about it a bit more, one method would be to iterate from the front of the string, then
		// begin iterating from the back, trying to detect the longest palidrome in the process. E.g
		//
		// baabcaaaa
		// 1. Start with index 0: b
		// 2. Begin comparing with index 4: c
		// 3. 0 and 4 do not match, continue
		// 4. 0 and 3 match, compare 1 and 2
		// 5. 1 and 2 match, we've navigated full string
		// 6. Find difference in indices
		//
		// This can be called recursively, and we can stop iterating once we've found a palindrome longer than
		// the length of the remaining substring.

		string longestPal = s[0].ToString();

		// Indices to track current comparision for palidrome
		int head = 0;
		int tail = 0;
		for (int i = s.Length - 1;  i > 0; i--)
		{
			head = 0;
			tail = i;
			while (tail >= head && s[head] == s[tail])
			{
				head++;
				tail--;
			}

			// Palidrome found if we exited loop and tail is less than head
			if (tail < head)
			{
				longestPal = s.Substring(0, i+1);
				break;
			}
		}

		// We can stop checking for the longest palindrome if the length of our current is greater
		// or equal to the length of the current string less 1. Else check for palindromes starting
		// at next character from start of the string.

		if (s.Length > 1 && longestPal.Length < s.Length - 1)
		{
			string nextPal = LongestPalindrome(s.Substring(1));
			if (nextPal.Length > longestPal.Length)
			{
				longestPal = nextPal;
			}
		} 

		return longestPal;
	}
}

// Post solution notes:
// This could be greatly improved with dynamic programming. This solution is O(n^2) and constantly
// reiterates over the same substtrings. We should instead store known palindromes based on the start
// and end indices of these palindromes in the parent string. We can then verify palindromes more quickly
// by expanding our checks around known palindromes.
//
// Ex: ababa
// If we already know bab is a palindrome in the form of p(1,3), then p(0,4) should be easier to check as
// we've already calculated the palindrome within.