using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace StringManipulationCodeChallenge
{
    public class StringManipulationWorkings
    {
        
        public static void ManipulateString(string input)
        {
            while (input.Length < 10)
            {
                Console.WriteLine("Characters not up to 10!\nEnter another string of words.");
                input = Console.ReadLine();
            }
            if(input.Length >= 10)
            {
                EncodeAndDecodeString(input);
            }
        }
        public static void EncodeAndDecodeString(string input)
        {
            string encoded;
            StringBuilder sb = new StringBuilder(input);
            int firstStrLen = sb.Length/2;
            int secondStrLen = sb.Length - firstStrLen;
            char[] firstStr = new char[firstStrLen];
            char[] secondStr = new char[secondStrLen];
            sb.CopyTo(0, firstStr, 0, firstStrLen);
            sb.CopyTo(firstStrLen, secondStr, 0, secondStrLen);
            string[] result = new string[]
            {new string(firstStr), new string(secondStr)};

            string newFirstString = "";
            string newSecondString = "";

            for (int i = 0; i < firstStrLen; i++)
            {
                if (i % 2 == 0)
                {
                    newFirstString += firstStr[i] + "" + secondStr[i];
                }
                else
                {
                    newSecondString += firstStr[i] + "" + secondStr[i];
                }
            }
            encoded = newSecondString + newFirstString;
            
            Console.WriteLine(newSecondString);
            Console.WriteLine(newFirstString);
            Console.WriteLine($"Here's your string encoded:\n{encoded}");

            StringBuilder strBuild = new StringBuilder(encoded);
            int decodedFirstStrLen = strBuild.Length/2;
            int decodedSecondStrLen = strBuild.Length - decodedFirstStrLen;
            char[] decodedFirstStr = new char[decodedFirstStrLen];
            char[] decodedSecondStr = new char[decodedSecondStrLen];
            sb.CopyTo(0, decodedFirstStr, 0, decodedFirstStrLen);
            sb.CopyTo(decodedFirstStrLen, decodedSecondStr, 0, decodedSecondStrLen);
            string[] decodedResult = new string[]
            {new string(decodedFirstStr), new string(decodedSecondStr)};

            Console.WriteLine("Here's your encoded string decoded:");
            foreach(string res in decodedResult)
            {
                Console.Write(res);
            }
        }
    }
}