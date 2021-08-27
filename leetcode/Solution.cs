/*
 * =================================================
 * Description:
 *  https://leetcode.com/problems/zigzag-conversion/
 * =================================================
 * Project:   leetcode
 * Developer: Alex Huot - huot.alex@gmail.com
 * Company:   Algorilla Inc.
 * Github:    https://github.com/Algorilla
 * 
 * Copyright  Algorilla Inc. - 2020
 * =================================================
 */

public class Solution
{
	/*
	Example: P A Y P A L I S H I R  I  N  G
			 0 1 2 3 4 5 6 7 8 9 10 11 12 13

	2 rows:

	P Y A I H R N		[0, 2, 4, 6, 8, 10, 12]		i * 2(r - 1)
	A P L S I I G		[1, 3, 5, 7, 9, 11, 13]
	
	3 rows:

	P   A   H   N		[0, 4, 8, 12]				i * 2(r - 1)
	A P L S I I G		[1, 3, 5, 7, 9, 11, 13]		(i + 1) * 2(r - 1)
	Y   I   R			[2, 6, 10]
	
	4 rows:

	P     I    N		[0, 6, 12]					i * 2(r - 1)
	A   L S  I G		[1, 5, 7, 11, 13]			(i + 1) * 2(r - 2)
	Y A   H R			[2, 4, 8, 10]
	P     I				[3, 9]

	 */
	public string Convert(string s, int numRows) 
	{
		return string.Empty;
    }
}