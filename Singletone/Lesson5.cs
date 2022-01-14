using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Singletone
{
	public class Manager1
	{
		public Manager1()
		{
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
