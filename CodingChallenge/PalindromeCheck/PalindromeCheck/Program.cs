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
                if(min > max)
                {
                    return true;
                }
                char a = 'A';
                char b = 'B';
                while (!aIsLetterOrDigit)
                {
                    if (Char.IsLetterOrDigit(str[min]))
                    {
                        a = str[min];
                        aIsLetterOrDigit = true;
                    }
                    else
                    {
                        min++;
                    }
                }
                while (!bIsLetterOrDigit)
                {
                    if (Char.IsLetterOrDigit(str[max]))
                    {
                        b = str[max];
                        bIsLetterOrDigit = true; ;
                    }
                    else
                    {
                        max--;
                    }
                }
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
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
