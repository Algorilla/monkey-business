/*
 * =================================================
 * Description:
 *  Test script.
 * =================================================
 * Project:   monkey-business
 * Developer: Alex Huot - huot.alex@gmail.com
 * Company:   Algorilla Inc.
 * Github:    https://github.com/Algorilla
 * 
 * Copyright  Algorilla Inc. - 2020
 * =================================================
 */

using System;

namespace monkey_business
{
    class Program
    {
        static void Main(string[] args)
        {
			Problem5 solution = new Problem5();

            Console.WriteLine(solution.LongestPalindrome(args[0]));
        }
    }
}
