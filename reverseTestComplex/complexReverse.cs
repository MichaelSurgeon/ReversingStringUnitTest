using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversingString;
using System;

namespace reverseTestComplex
{
    [TestClass]
    public class complexReverse
    {
        [TestMethod]
        public void DoesReverseWithSpaces_ReverseComplete_ReturnsReverseTrue()
        {
            try
            {
                //arrange
                var inputstring = "Hello Foo";

                //act
                var outputstring = StringUtilities.Reverse(inputstring);

                //assert
                Assert.AreEqual(outputstring, "ooF olleH");
            }
            catch (Exception)
            { 
                Console.WriteLine("Oops something went wrong in the complex test");
            }

        }
    }
}
