using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Singletone
{
	public class Manager2
	{
		private static int _instanceCount;

		/// <summary>
		/// Static Constructor
		/// Note: Access modifiers are not allowed on static constructors!
		/// </summary>
		static Manager2()
		{
			_instanceCount = 0;
		}

		public Manager2()
		{
			_instanceCount++;

			if (_instanceCount > 1)
            {
				throw (new System.Exception("No more than one object permited!"));
			}
		}

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
