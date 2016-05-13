using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
* Aslan Mirsakiyev
* #300850326
* 13 of May 2016
* Version 0.5-Refactored
*/
namespace COMP123_S2016_Lesson1B
{
    /**
    * This is driver class for our program
    *
    * @class Program
    */
    public class Program
    {
        /**
        * Main method for class Program
        * 
        * @param {string[]} args
        * @constructor Main
        */
        static void Main(string[] args)
        {
            GetUserName();
        }

        /**
        * This method reads the UserName from the Console
        * @method GetUserName
        * @return {string} UserName
        */

        public static string GetUserName()
        {
            // Initilize Variables      
            string UserName = "";

            OutputStringToConsole("Enter UserName: ", false);
            UserName=Console.ReadLine();

            Console.WriteLine("\n<><><><><><><><><><><><><><>");
            Console.WriteLine();
            Console.WriteLine("You entered: " + UserName);

            return UserName;
        }

        /**
        * This method srites a string to the console. Parameters allow the user
        * to choose to add a newLine character
        *
        * @method OutputStringToConsole
        * @param {string} outupString
        * @param {bool} hasNewLine
        * @return {string} UserName
        */
        public static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
           // refactored using the ternary operator
           string suffixString=hasNewLine  ? "\n" : "";
            Console.Write(outputString + suffixString);

            return outputString;
        }
    }
}
