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

		static void Main(string[] args) {
			RGBColor color = new RGBColor() { red = 34, blue = 100, green = 255 };
			RGBColor color2 = new RGBColor() { red = 0, blue = 0, green = 0 };

			Console.WriteLine(color.red + ", " + color.green + ", " + color.blue);
			Console.WriteLine(color2);
		}
	}
}
