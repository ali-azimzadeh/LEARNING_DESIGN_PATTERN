using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Singletone
{
	public class Utilities2
	{
		public static float Average(float a, float b)
		{
			return ((a + b) / 2);
		}

		public static float Average(params float[] numbers)
		{
			float fltSum = 0;

			foreach (float fltNumber in numbers)
			{
				fltSum += fltNumber;
			}

			return (fltSum / numbers.Length);
		}
	}
}
