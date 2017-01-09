using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMultipleWaysOfConcatenatingStrings
{
    [TestClass]
    public class UnitTestMultipleWaysOfConcatenatingLongStrings
    {
        [TestMethod]
        public void TestLongStringConcatUsingStringBuilder()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.LongStringConcatUsingStringBuilder("a", 10000);
            //Assert
            //Assert.AreEqual(result, "?");
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestLongStringConcatUsingPlusOperator()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.LongStringConcatUsingPlusOperator("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestLongStringConcatUsingStringFormat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.LongStringConcatUsingStringFormat("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void LongStringConcatUsingStringConcat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.LongStringConcatUsingStringConcat("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void LongStringConcatUsingStringJoin()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.LongStringConcatUsingStringJoin("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestLongStringConcatUsingStringAggregate()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.LongStringConcatUsingStringAggregate("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }
    }
}
