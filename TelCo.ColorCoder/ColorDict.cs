using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace TelCo.ColorCoder{
	class ColorDict{
		int pairNumber = 1;
		public static void colorDict(){
			for(int i = 0; i < 5; ++i){
				for(int j = 0; j < 5; ++j){
					Console.Writeline("[In]Pair Number: {0}, Color Major: {1}, ColorMinor: {2}\n",pairNumber,NumberToColorPair.colorMapMajor[i],NumberToColorPair.colorMapMinor[j]);
					pairNumber++;
				}
			}
		}
	}
}