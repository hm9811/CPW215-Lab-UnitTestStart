﻿using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            return Regex.IsMatch(ssn, @"^(\d{3}-?\d{2}-?\d{4}|XXX-XX-XXXX)$");
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            if(numToTest < minValue || numToTest > maxValue)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
