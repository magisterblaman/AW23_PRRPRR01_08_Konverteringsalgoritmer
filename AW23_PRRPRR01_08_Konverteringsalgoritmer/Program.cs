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

		static CMYKColor ConvertRGBToCMYK(byte r, byte g, byte b) {
			double r_prime = r / 255.0;
			double g_prime = g / 255.0;
			double b_prime = b / 255.0;

			double k = 1 - Max(r_prime, g_prime, b_prime);
			double c = (1 - r_prime - k) / (1 - k);
			double m = (1 - g_prime - k) / (1 - k);
			double y = (1 - b_prime - k) / (1 - k);

			return new CMYKColor() { cyan = c, magenta = m, yellow = y, key = k };
		}

		static double Max(double value1, double value2, double value3) {
			double max = double.MinValue;
			if (value1 > max) {
				max = value1;
			}
			if (value2 > max) {
				max = value2;
			}
			if (value3 > max) {
				max = value3;
			}
			return max;
		}

		static void Main(string[] args) {
			CMYKColor color = ConvertRGBToCMYK(0, 255, 0);
			Console.WriteLine(color.cyan + ", " + color.magenta + ", " + color.yellow + ", " + color.key);
		}
	}
}
