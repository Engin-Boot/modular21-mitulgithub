using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder
{
    class ColorPair
    {
        public Color majorColor;
        public Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            
            int majorIndex = -1;
            for (int i = 0; i < Program.colorMapMajor.Length; i++)
            {
                if (Program.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

      
            int minorIndex = -1;
            for (int i = 0; i < Program.colorMapMinor.Length; i++)
            {
                if (Program.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * Program.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}