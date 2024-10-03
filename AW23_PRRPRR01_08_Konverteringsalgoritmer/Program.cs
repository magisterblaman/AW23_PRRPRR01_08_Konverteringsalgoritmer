using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_08_Konverteringsalgoritmer {
	internal class Program {
		static double ConvertMetersToKilometers(int m) {
			return m / 1000.0;
		}

		static double CalculateSpeed(int distance, int time) {
			return (double)distance / time;
		}

		static double CalculateSomethingWithXAndY(int x, int y) {
			return x + y;
		}

		static int CalculateVolume(int width, int height, int depth) {
			return width * height * depth;
		}

		static int CalculateVolume2(Size size) {
			return size.Width * size.Height * size.Depth;
		}

		static RGBColor ConvertToGrayscale(RGBColor color) {
			byte average = (byte)((color.red + color.blue + color.green)/3);

			return new RGBColor() { red = average, green = average, blue = average };
		}

		static void Main(string[] args) {
			int index = 17;
			int cols = 5;

			int r = index / cols;
			int c = index % cols; // modulo
		}
	}
}
