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
			//Console.WriteLine(CalculateSpeed(5000, 10000));

			int w = 43;
			int h = 543857;
			int d = 43784;

			Console.WriteLine(CalculateVolume(w, h, d));

			Size mySize = new Size();
			mySize.Width = 43;
			mySize.Height = 543857;
			mySize.Depth = 43784;

			Console.WriteLine(CalculateVolume2(mySize));
		}
	}
}
