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

        //[TestMethod]
        //public void FoundPositionOfAllTheThings()
        //{
        //    Parse parse = new Parse();
        //    var expected = 10;
        //    var actual = parse.FindPositions();
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void FindFirstTerm()
        {
            String input = "20+59";
            Parse parse = new Parse();
            String expected = "20";
            String actual = parse.FirstTerm(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindSecondTerm()
        {
            String input = "20+59";
            Parse parse = new Parse();
            String expected = "59";
            String actual = parse.SecondTerm(input);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindSymbol()
        {
            String input = "20+59";
            Parse parse = new Parse();
            String expected = "+";
            String actual = parse.Symbol(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
