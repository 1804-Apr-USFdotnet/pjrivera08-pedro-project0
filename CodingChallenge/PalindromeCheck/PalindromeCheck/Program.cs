using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    public class Program
    {
        public static bool PalindromeCheckMethod(string str)
        {
            int min = 0;
            int max = str.Length - 1;
            while (true)
            {
                bool aIsLetterOrDigit = false;
                bool bIsLetterOrDigit = false;
                
                if (min > max)
                {
                    return true; //If max gets lower than min then the string MUST be a palindrome
                }
                char a = 'A'; //Compiler didn't like me leaving these values blank
                char b = 'B';

                //Program will not assign the char from the string until it is confirmed that 
                //the char is a Letter or a digit (not a punctuation mark)
                while (!aIsLetterOrDigit)
                {
                    if (Char.IsLetterOrDigit(str[min]))
                    {
                        a = str[min];
                        aIsLetterOrDigit = true; //Allows the isLetterOrDigit loop to be exited
                    }
                    else
                    {
                        min++; //Skip the punctuation mark
                    }
                }
                //Program will not assign the char from the string until it is confirmed that 
                //the char is a Letter or a digit (not a punctuation mark)
                while (!bIsLetterOrDigit)
                {
                    
                    if (Char.IsLetterOrDigit(str[max]))
                    {
                        b = str[max];
                        bIsLetterOrDigit = true; //Allows the isLetterOrDigit loop to be exited
                    }
                    else
                    {
                        max--; //Skip the punctuation mark
                    }
                }
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false; //If the characters do not match then the string MUST NOT be a palindrome
                }
                min++;
                max--;
            }
        }
        static void Main(string[] args)
        {
          Console.ReadKey();
        }
    }
    
}
