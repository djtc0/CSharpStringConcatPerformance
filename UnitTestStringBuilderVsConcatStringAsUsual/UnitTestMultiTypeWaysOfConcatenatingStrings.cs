using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMultipleWaysOfConcatenatingStrings
{
    [TestClass]
    public class UnitTestMultipleWaysOfConcatenatingShortStrings
    {
        private TestContext myTestContext;

        public TestContext TestContext
        {
            get { return myTestContext; }
            set { myTestContext = value; }
        }
        
        //[TestMethod]
        public void TestShortStringConcatUsingPlusOperator()
        {
            //Arranje
MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.ShortStringConcatUsingPlusOperator("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringBuilder()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.ShortStringConcatUsingStringBuilder("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringConcat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.ShortStringConcatUsingStringConcat("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringFormat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.ShortStringConcatUsingStringFormat("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringJoin()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.ShortStringConcatUsingStringJoin("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }
        
        //[TestMethod]
        [DeploymentItem(@"Data\TestData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\TestData.xml", "Row", DataAccessMethod.Sequential)]
        public void TestXMLDataDrivenShortStringConcatUsingPlusOperator()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.ShortStringConcatUsingPlusOperator((String)TestContext.DataRow["inputString"], (String)TestContext.DataRow["stringToAppend"]);
            //Assert
            Assert.AreEqual(result, TestContext.DataRow["Result"]);
        }

            
        //[TestMethod]
        public void testCollectDataFromLongRunOffBothConcatStringUsingStringBuilderAndConcatStringUsingPlusOperator()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();

            //Act
            multiTypeStringBuilder.CollectDataFromLongRunOffBothConcatStringUsingStringBuilderAndConcatStringUsingPlusOperator(1000);

            //Assert
        }

        //[TestMethod]
        public void testcollectDataFromLongRunOffBothStringBuilderAndConcatStringAsUsualCustomTiming()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();

            //Act
            multiTypeStringBuilder.CollectDataFromLongRunOffBothStringBuilderAndConcatStringAsUsualCustomTiming(1000);

            //Assert
        }

        //[TestMethod]
        public void TestVeryLongStringBuilderConcatManyTimes()
        {
            //Arranje
MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            multiTypeStringBuilder.LongStringConcatUsingPlusOperatorManyTimes(1000, 10000);
            //Assert

        }

        //[TestMethod]
        public void TestveryLongStringConcatAsUsualManyTimes()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();

            //Act
            multiTypeStringBuilder.LongStringConcatUsingPlusOperatorManyTimes(1000, 10000);

            //Assert

        }
    }
}
