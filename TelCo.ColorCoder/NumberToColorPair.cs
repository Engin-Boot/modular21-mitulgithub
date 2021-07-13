using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder{
    
        class NumberToColorPair{

            private static Color[] colorMapMajor;
            private static Color[] colorMapMinor;
            internal class ColorPair
            {
                internal Color majorColor;
                internal Color minorColor;
                public override string ToString()
                {
                    return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
                }
            }

            static NumberToColorPair()
            {
                colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
                colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
            }
            private static ColorPair GetColorFromPairNumber(int pairNumber)
            {
                // The function supports only 1 based index. Pair numbers valid are from 1 to 25
                int minorSize = colorMapMinor.Length;
                int majorSize = colorMapMajor.Length;
                if (pairNumber < 1 || pairNumber > minorSize * majorSize)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
                }
            
                // Find index of major and minor color from pair number
                int zeroBasedPairNumber = pairNumber - 1;
                int majorIndex = zeroBasedPairNumber / minorSize;
                int minorIndex = zeroBasedPairNumber % minorSize;

                // Construct the return val from the arrays
                ColorPair pair = new ColorPair() { majorColor = colorMapMajor[majorIndex],
                    minorColor = colorMapMinor[minorIndex] };
            
                // return the value
                return pair;
        }
        }
}