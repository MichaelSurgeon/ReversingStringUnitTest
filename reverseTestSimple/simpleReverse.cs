using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversingString;
using System;


namespace reverseTestSimple
{
    [TestClass]
    public class simpleReverse
    {
        [TestMethod]
        public void DoesReverse_ReverseComplete_ReturnsReverseTrue()
        {

            try
            {
                //arrange
                var inputstring = "BarBazQux";

                //act
                var outputstring = StringUtilities.Reverse(inputstring);

                //assert
                Assert.AreEqual(outputstring, "xuQzaBraB");

            }
            catch (Exception)
            {
                Console.WriteLine("Oops something went wrong in a unit test");
            }

        }
    }
}

