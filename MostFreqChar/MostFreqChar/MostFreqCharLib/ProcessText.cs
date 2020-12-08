using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S A
 * CSC-253
 * 9.16.2020
 */

namespace MostFreqCharLib
{
    public class ProcessText //Process Text Class
    {
        public static void MostFreqChar(String aString, out char freqChar) //Find most frequent character within a string.
        {
            if(aString.Equals(null)) //if the string is null..
            {
                freqChar = '*'; //..,then set freqChar to * asterick.
            }
            else 
            {

                int count, max = 0;
                char mostFreq = ' '; //set mostFreq to ' ' single space.

                NoSpaces(ref aString);//remove spaces from string.
                LcaseString(ref aString); //lower the casing of string.

                foreach (char ch in aString) //for every char in the string..
                {
                    count = 0; //set count to 0.
                    foreach (char ch2 in aString) //..iterate through the string.
                    {
                        if (ch == ch2)//find matching chars within the same string..
                        {
                            ++count; //..and count matches for that char.
                        }
                    }
                    if (count > max) //if the count is greater than the max..
                    {
                        max = count; //..,then max is assigned the value of count..
                        mostFreq = ch; //..and that char is assigned to mostFreq.
                    }
                }
                freqChar = mostFreq; //assign most frequent character to freqChar
            }

            
        }
        public static void NoSpaces(ref String input) //remove all spaces
        {
            while (input.Contains(" "))
            {
                input = input.Replace(" ", "");
            }
        }

        public static void LcaseString(ref String input) //lowercase string
        {
            input = input.ToLower();
        }
    }
}
