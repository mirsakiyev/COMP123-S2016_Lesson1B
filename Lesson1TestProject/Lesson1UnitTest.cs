using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static COMP123_S2016_Lesson1B.Program;

namespace Lesson1TestProject
{
    [TestClass]
    public class Lesson1UnitTest
    {
        /**
        * Unit Test for OutputStringToConsole MEthod of the Program class
        *
        * @method OutputStringToConsoleTestMethod1
        */
        [TestMethod]
        public void OutputStringToConsoleTestMethod1()
        {
            // Arrange 
            string outputString="Enter UserName";
            bool hasNewLine=false;
            string actualResult;
            string expectedResult="Enter UserName";

            // Act
            actualResult =OutputStringToConsole(outputString, hasNewLine);


            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
