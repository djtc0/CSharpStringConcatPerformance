using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMultipleWaysOfConcatenatingStrings
{
    [TestClass]
    public class UnitTestMultipleWaysOfConcatenatingMultipleStrings
    {
        [TestMethod]
        public void TestMultipleConcatUsingStringBuilder()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.MultipleConcatUsingStringBuilder("a", 10000);
            //Assert
            //Assert.AreEqual(result, "?");
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestMultipleConcatUsingPlusOperator()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.MultipleConcatUsingPlusOperator("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestLongStringConcatUsingStringFormat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.MultipleConcatUsingStringFormat("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestMultipleConcatUsingStringConcat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.MultipleConcatUsingStringConcat("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestMultipleConcatUsingStringJoin()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.MultipleConcatUsingStringJoin("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }

        [TestMethod]
        public void TestMultipleConcatUsingStringAggregate()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.MultipleConcatUsingStringAggregate("a", 10000);
            //Assert
            Assert.AreEqual(result.Length, 10000);
        }
    }
}
