using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    /// <summary>
    /// Test code for the class
    /// </summary>
        
    class Test{
        static void PrintManual(IColorDict destination)
        {
            destination.manual();
        }
         
        // /// <param name="args"></param> 
        private static void Main(string[] args)
        {

            PrintManual(new ColorDict());
            // PrintManual(new ColorDictTest());
            ColorDictTest testObj = new ColorDictTest();
            PrintManual(testObj);
            Debug.Assert(testObj.numberOfPrintedLines == ColorMap.colorMapMajor.Length*ColorMap.colorMapMinor.Length);
            Console.WriteLine("End of Program");
            // int pairNumber = 4;
            // ColorPair testPair1 = ColorMapUtil.GetColorFromPairNumber(pairNumber);
            // Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            // Debug.Assert(testPair1.majorColor == Color.White);
            // Debug.Assert(testPair1.minorColor == Color.Brown);

            // pairNumber = 5;
            // testPair1 = ColorMapUtil.GetColorFromPairNumber(pairNumber);
            // Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            // Debug.Assert(testPair1.majorColor == Color.White);
            // Debug.Assert(testPair1.minorColor == Color.SlateGray);

            // pairNumber = 23;
            // testPair1 = ColorMapUtil.GetColorFromPairNumber(pairNumber);
            // Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", pairNumber, testPair1);
            // Debug.Assert(testPair1.majorColor == Color.Violet);
            // Debug.Assert(testPair1.minorColor == Color.Green);

            // ColorPair testPair2 = new ColorPair() { majorColor = Color.Yellow, minorColor = Color.Green };
            // pairNumber = ColorMapUtil.GetPairNumberFromColor(testPair2);
            // Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", testPair2, pairNumber);
            // Debug.Assert(pairNumber == 18);

            // testPair2 = new ColorPair() { majorColor = Color.Red, minorColor = Color.Blue };
            // pairNumber = ColorMapUtil.GetPairNumberFromColor(testPair2);
            // Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", testPair2, pairNumber);
            // Debug.Assert(pairNumber == 6);
        }
    }
}   