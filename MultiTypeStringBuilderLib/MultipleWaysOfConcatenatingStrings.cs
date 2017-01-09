using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleWaysOfConcatenatingStringsLib
{
    public class MultipleWaysOfConcatenatingStrings
    {
        public string TwoStringConcatUsingStringBuilder(String inputString, string stringToAppend)
        {
            StringBuilder sb = new StringBuilder(inputString);
            sb.Append(stringToAppend);
            String result = sb.ToString();
            return result;
        }

        public string TwoStringConcatUsingPlusOperator(String inputString, string stringToAppend)
        {
            inputString  += stringToAppend;
            return inputString;
        }

        public string TwoStringConcatUsingStringFormat(String inputString, string stringToAppend)
        {
            string result = String.Format("{0}{1}", inputString, stringToAppend);
            return result;
        }

        public string TwoStringConcatUsingStringConcat(String inputString, string stringToAppend)
        {
            String result = String.Concat(inputString, stringToAppend);
            return result;
        }

        public string TwoStringConcatUsingStringJoin(String inputString, string stringToAppend)
        {
            //does not enter on the validation of the string concatenation performance
            List<String> strings = new List<string>();
            strings.Add(inputString);
            strings.Add(stringToAppend);
            string stringSeparator = "";

            String result = String.Join(stringSeparator , strings);
            return result;
        }

        //fastest
        public string MultipleConcatUsingStringBuilder(string stringToAppend, int repeats)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < repeats; i++)
            {
                sb.Append(stringToAppend);
            }
            string result =  sb.ToString();

            return result;
        }

        //slowest
        public string MultipleConcatUsingPlusOperator(string stringToAppend, int repeats)
        {
            String result = "";
            for (int i = 0; i < repeats; i++)
            {
                result += stringToAppend;
            }
            return result;
        }

        public string MultipleConcatUsingStringFormat(string stringToAppend, int repeats)
        {
            String result = "";
            for (int i = 0; i < repeats; i++)
            {
                result = String.Format("{0}{1}", stringToAppend, result);
            }
            return result;
        }

        public string MultipleConcatUsingStringConcat(string stringToAppend, int repeats)
        {
            String result = "";
            for (int i = 0; i < repeats; i++)
            {
                result = String.Concat(stringToAppend, result);
            }
            return result;
        }

        public string MultipleConcatUsingStringJoin(string stringToAppend, int repeats)
        {
            List<String> listOfString = new List<string>();
            for (int i = 0; i < repeats; i++)
            {
                listOfString.Add(stringToAppend);
            }

            String result = "";
            for (int i = 0; i < repeats; i++)
            {
                result = String.Join("", listOfString);
            }
            return result;
        }

        public string MultipleConcatUsingStringAggregate(string stringToAppend, int repeats)  
        {
            List<String> listOfString = new List<string>();
            for (int i = 0; i < repeats; i++)
            {
                listOfString.Add(stringToAppend);
            }

            string result = listOfString.Aggregate((a,b) => a + b);
            
            return result;
        }

        public string ConcatTwoLongStringsUsingPlusOperator()
        {
            string s1 = MultipleConcatUsingStringBuilder("a", 10000);
            string s2 = MultipleConcatUsingStringBuilder("a", 10000);

            string result = s1 + s2;

            return result;
        }

        public string ConcatTwoLongStringsUsingStringBuilder()
        {
            StringBuilder sb1 = new StringBuilder(MultipleConcatUsingStringBuilder("a", 10000));
            StringBuilder sb2 = new StringBuilder(MultipleConcatUsingStringBuilder("b", 10000));
            sb1.Append(sb2);
            return sb1.ToString();
        }

        public void CollectDataFromLongRunOffBothConcatStringUsingStringBuilderAndConcatStringUsingPlusOperator(int howManyRuns)
        {
            for (int i = 0; i < howManyRuns; i++)
            {
                MultipleConcatUsingStringBuilder("a", 10000);
                MultipleConcatUsingPlusOperator("a", 10000);

            }
        }

        public void CollectDataFromLongRunOffBothStringBuilderAndConcatStringAsUsualCustomPreformanceTiming(int howManyRuns)
        {
            double[] timingsStringBuilderConcat = new double[howManyRuns];
            double[] timingsConcatAsUsual = new double[howManyRuns];
            DateTime before, after;

            for (int i = 0; i < howManyRuns; i++)
            {
                before = DateTime.Now;                
                MultipleConcatUsingStringBuilder("a", 10000);
                after = DateTime.Now;
                timingsStringBuilderConcat[i] = (after - before).TotalMilliseconds;

                before = DateTime.Now;
                MultipleConcatUsingPlusOperator("a", 10000);
                after = DateTime.Now;
                timingsConcatAsUsual[i] = (after - before).TotalMilliseconds;
            }
        }

        public void LongStringConcatUsingStringBuilderManyTimes(int howManyRuns, int howManyConcats)
        {
            StringBuilder sb = new StringBuilder();

            for (int currentRunValue = 0; currentRunValue < howManyRuns; currentRunValue++)
            {
                for (int appendRun = 0; appendRun < howManyConcats; appendRun++)
                {
                    sb.Append(howManyConcats.ToString());
                }

                sb.Clear();
            }
        }

        public void LongStringConcatUsingPlusOperatorManyTimes(int howManyRuns, int howManyConcats)
        {
            String result = "";

            for (int currentRunValue = 0; currentRunValue < howManyRuns; currentRunValue++)
            {
                for (int concatRun = 0; concatRun < howManyConcats; concatRun++)
                {
                    result += concatRun.ToString();
                }

                result = "";
            }
        }
    }
}
