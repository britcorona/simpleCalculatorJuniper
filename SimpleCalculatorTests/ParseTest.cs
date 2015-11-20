using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void ParseCreateInstance()
        {
            Parse parse = new Parse();
            Assert.IsNotNull(parse);
        }

        [TestMethod]
        public void SeeingTheString()
        {
            Parse parse_string = new Parse();

            parse_string.Input = "1 + 1";
            Assert.AreEqual("1 + 1", parse_string.Input);
        }

        [TestMethod]
        public void TakeStringApart()
        {
            //string[] stringSeparators = new string[] { " " };
            //string[] result;
            //string string_split = "2 + 2";

            //result = string_split.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            //string[] expected = new string[] { "2", "+", "2"};

            //Assert.AreEqual(result, expected);

            Parse parse_string = new Parse();
            
        }
    }
}
