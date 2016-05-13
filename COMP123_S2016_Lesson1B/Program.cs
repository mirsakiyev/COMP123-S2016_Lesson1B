using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
* Aslan Mirsakiyev
* #300850326
* 13 of May 2016
* Version 0.3-Updated comments for my driver class
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
            Console.Write("Enter User Name: ");
            UserName=Console.ReadLine();

            Console.WriteLine("/n_________________________");
            Console.WriteLine("You entered: " + UserName);

            return UserName;
        }
    }
}
