using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Singletone
{
	public sealed class Manager3
	{
		#region Singleton Pattern
		private static Manager3 _instance;

		public static Manager3 GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Manager3();
			}

			return (_instance);
		}

		private Manager3()
		{
		}
		#endregion /Singleton Pattern

		private int _age;
		public int Age
		{
			get
			{
				return (_age);
			}
			set
			{
				if ((value >= 1) && (value <= 99))
				{
					_age = value;
				}
			}
		}

		public string FullName
		{
			get;
			set;
		}

		public void ShowInfo()
		{
			string message =
						$"I'm {FullName} and {Age} years old.";

			System.Windows.Forms.MessageBox.Show(message);
		}
	}
}
