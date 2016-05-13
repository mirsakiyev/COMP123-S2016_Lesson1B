using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
* Aslan Mirsakiyev
* #300850326
* 13 of May 2016
* Version 0.4-Extracted OutputStringToConsole from GetUserName method
*/
namespace COMP123_S2016_Lesson1B
{
    /**
    * This is driver class for our program
    *
    * @class Program
    */
    class Program
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
        private static string OutputStringToConsole(string outputString, bool hasNewLine)
        {
            if (hasNewLine)
            {
                Console.WriteLine(outputString);
            }
            else
            {
                Console.Write(outputString);
            }
          
            return outputString;
        }
    }
}
