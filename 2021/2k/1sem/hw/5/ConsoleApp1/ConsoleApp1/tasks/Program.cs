using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            RegexWithNumbers regexWithNumbers = new RegexWithNumbers();
            
            regexWithNumbers.runFirstTaskWithNumbers(new string[] {"10101010", "0000", "1111", "01010101", "01111111"});
            
            regexWithNumbers.run("^\\d*[02468]$", "03c");
            
            regexWithNumbers.run("^((([13579])+([02468]{0,3})?)*)$", "03b");
            
            regexWithNumbers.run("^[02468]{3,6}$", "04b");
            
            regexWithNumbers.run("^(\\d*([02468]{2}))*$", "05b");
            
            
            
            
            //
            // string pattern03b = "^((([13579])+([02468]{0,3})?)*)$";
            //
            // string pattern04b = "^[02468]{3,6}$";
            //
            // string pattern05b = "^(\\d*([02468]{2}))*$";
            //
            // string pattern06c = "^(\\w*)\\.(\\w*)$";
        }
        
        //pattern = "^\\d*[02468]$"(); "^((([13579])+([02468]{0,3})?)*)$"(03b);

    }
}