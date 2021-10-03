using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    public class RegexWithNumbers
    {

        public void run(string regex, string task)
        {
            int counter = 0;
            int allCounts = 0;
            while (counter != 10)
            {
                allCounts++;
                var rand = new Random();
                var number = rand.Next();
                if (isMultiple(number.ToString(), regex))
                {
                    counter++;
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine(allCounts + " - count of iterations("+task+")");
        }

        public void runFirstTaskWithNumbers(string[] array)
        {
            isTrueBinary(array);
            Console.WriteLine();
        }
        
        public static bool isMultiple(string number, string pattern)
        {
            if (Regex.IsMatch(number, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public static void isTrueBinary(string[] arr)
        {
            string pattern02c = "(^(01)*$)|(^(10)*$)|(^(1)*$)|(^(0)*$)";
            for (int i = 0; i < arr.Length; i++)
            {
                if (Regex.IsMatch(arr[i], pattern02c))
                {
                    Console.Write((i + 1) + " ");
                }
            }
            
        }
        
        
    }
}