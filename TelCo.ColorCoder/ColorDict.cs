using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    public interface IColorDict
    {
         void manual();
    }

    public  class ColorDict : IColorDict
    {
        
        public void manual()
        {

           int pairnumber = 1;
            for (int i = 0; i < ColorMap.colorMapMajor.Length; i++)
            {
                for (int j = 0; j < ColorMap.colorMapMinor.Length; j++)
                {

                    Console.WriteLine("[In]Pair Number: {0},Colors: major{1} - minor{2}\n", pairnumber, ColorMap.colorMapMajor[i], ColorMap.colorMapMinor[j]);
                    pairnumber++;
                }
            }

        }

    }

    class ColorDictTest : IColorDict
    {
        public int numberOfPrintedLines = 0;
        public void manual()
        {
            int pairNumber = 1;
            for (int i = 0; i < ColorMap.colorMapMajor.Length; i++)
            {
                for (int j = 0; j < ColorMap.colorMapMinor.Length; j++)
                {
                   ColorPair testColorPair = ColorMapUtil.GetColorFromPairNumber(pairNumber); 
                   Debug.Assert(testColorPair.majorColor == ColorMap.colorMapMajor[i]);
                   Debug.Assert(testColorPair.minorColor == ColorMap.colorMapMinor[j]);

                   testColorPair.majorColor = ColorMap.colorMapMajor[i];
                   testColorPair.minorColor = ColorMap.colorMapMinor[j];

                   int pairNo = ColorMapUtil.GetPairNumberFromColor(testColorPair);
                   Debug.Assert(pairNo == pairNumber);
                   ++pairNumber;
                   ++numberOfPrintedLines;
                }
            }
        }
    }

    
}