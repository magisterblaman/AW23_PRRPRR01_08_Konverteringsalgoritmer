using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AW23_PRRPRR01_08_Konverteringsalgoritmer {
	internal class Program {
		static double ConvertMetersToKilometers(int m) {
			return m / 1000.0;
		}
		static void Main(string[] args) {
			Console.WriteLine(ConvertMetersToKilometers(953));
		}
	}
}
