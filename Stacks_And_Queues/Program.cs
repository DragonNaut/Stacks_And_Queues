using System;

namespace Stacks_And_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            CSTack aList = new CSTack();
            string ch;
            string word = "sees";
            bool isPalindrome = true;

            for (int x = 0; x < word.Length; x++)
            {
                aList.push(word.Substring(x,1));

            }

            int pos = 0;

            while (aList.count > 0)
            {
                ch = aList.pop().ToString();
                if (ch != word.Substring(pos,1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;
            }
            
            if (isPalindrome)
            {
                Console.WriteLine($"{word} is a palindrome.");
            }
            else
            {
                    Console.WriteLine($"{word} is not a palindrome.");

            }
        }
    }
}
