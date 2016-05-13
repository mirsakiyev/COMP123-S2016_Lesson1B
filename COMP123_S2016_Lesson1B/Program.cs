using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Aslan Mirsakiyev
// #300850326
// 13 of May 2016
// Version 1.0
namespace COMP123_S2016_Lesson1B
{
    class Program
    {
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
