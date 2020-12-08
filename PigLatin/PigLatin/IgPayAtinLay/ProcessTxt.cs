using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * S. Apulu
 * CSC-253
 * 9.16.2020
 * Plaintext to Pig Latin
 * 
 */

namespace IgPayAtinLay
{
    public class ProcessTxt
    {
        public static String ToPigLatin(String aString)
        {
            String[] wordArr = SplitText(aString); //split the string into words

            for(int i = 0; i < wordArr.Length; ++i) //iterate through the array
            {
                wordArr[i] = PigLatinize(wordArr[i]); //pigLatinize each word
            }

            aString = JoinText(wordArr); //join the string together
            EvenSpaced(ref aString); //check spacing
            return aString; //return Pig Latinized Text
        }

        public static string PigLatinize(String aString)
        {
            return aString.Substring(1) + aString.Substring(0, 1) + "ay ";
        }

        public static String[] SplitText(String aString)
        {
            return aString.Split(null);
        }

        public static void EvenSpaced(ref String aString)
        {
            while(aString.Contains("  "))
            {
                aString = aString.Replace("  ", " ");
            }
            aString = aString.TrimEnd(' ');
        }

        public static String JoinText(String[] stringArr)
        {
            return String.Join("", stringArr);
        }
    }
}
