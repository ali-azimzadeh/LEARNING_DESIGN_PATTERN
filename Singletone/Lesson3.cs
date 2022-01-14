using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Singletone
{
	public sealed class Utilities3
	{
		// User can not create any instance!
		private Utilities3()
		{
		}

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

		/// <summary>
		/// Note: I forgot to put [static] keyword for this function,
		/// But compiler did not warn me!
		/// </summary>
		/// <param name="numbers"></param>
		/// <returns></returns>
		public float Sum(params float[] numbers)
		{
			float fltSum = 0;

			foreach (float fltNumber in numbers)
			{
				fltSum += fltNumber;
			}

			return (fltSum);
		}
	}
}
