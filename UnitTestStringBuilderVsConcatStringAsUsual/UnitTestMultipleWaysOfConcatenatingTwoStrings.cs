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
        [DeploymentItem(@"Data\TestData.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\TestData.xml", "Row", DataAccessMethod.Sequential)]
        public void TestXMLDataDrivenShortStringConcatUsingPlusOperator()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.TwoStringConcatUsingPlusOperator((String)TestContext.DataRow["inputString"], (String)TestContext.DataRow["stringToAppend"]);
            //Assert
            Assert.AreEqual(result, TestContext.DataRow["Result"]);
        }

        //[TestMethod]
        public void TestShortStringConcatUsingPlusOperator()
        {
            //Arranje
MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.TwoStringConcatUsingPlusOperator("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringBuilder()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.TwoStringConcatUsingStringBuilder("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringConcat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.TwoStringConcatUsingStringConcat("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringFormat()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multiTypeStringBuilder = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multiTypeStringBuilder.TwoStringConcatUsingStringFormat("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
        }

        //[TestMethod]
        public void TestShortStringConcatUsingStringJoin()
        {
            //Arranje
            MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings multipleWaysOfConcatenatingStrings = new MultipleWaysOfConcatenatingStringsLib.MultipleWaysOfConcatenatingStrings();
            //Act
            string result = multipleWaysOfConcatenatingStrings.TwoStringConcatUsingStringJoin("Daniel", " Carrilho");
            //Assert
            Assert.AreEqual(result, "Daniel Carrilho");
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
            multiTypeStringBuilder.CollectDataFromLongRunOffBothStringBuilderAndConcatStringAsUsualCustomPreformanceTiming(1000);

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
