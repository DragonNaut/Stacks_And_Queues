using System;

namespace Stacks_And_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            CSTack aList = new CSTack();
            string ch;
            string testWord = "ab";
            bool isPalindrome = true;

            for (int x = 0; x < testWord.Length; x++)
            {
                aList.push(testWord.Substring(x,1));

            }

            int pos = 0;

            while (aList.count > 0)
            {
                ch = aList.pop().ToString();
                if (ch != testWord.Substring(pos,1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;
            }
            
            if (isPalindrome)
            {
                Console.WriteLine($"{testWord} is a palindrome.");
            }
            else
            {
                    Console.WriteLine($"{testWord} is not a palindrome.");

            }
        }
    }
}
