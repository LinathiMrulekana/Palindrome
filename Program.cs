using System;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reversStr = string.Empty;
            string inputStr = string.Empty;
            Console.Write("Enter a name: ");
            inputStr = Console.ReadLine();
            if (inputStr != null)
            {
                for (int i = inputStr.Length - 1; i >= 0; i--)
                {
                    reversStr += inputStr[i].ToString();
                }
                if (reversStr == inputStr)
                {
                    Console.WriteLine("String is palindrome input = {0} and Output = {1}", inputStr , reversStr);
                }
                else
                {
                    Console.WriteLine("String is not a palindrome Input = {0} and Output = {1}", inputStr , reversStr);
                }
            }
         Console.ReadLine();
        }
    }
}
 