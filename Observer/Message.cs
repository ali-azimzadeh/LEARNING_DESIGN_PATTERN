using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEARNING_DESIGN_PATTERN.Observer
{
	public class Message : IMessage
	{
		public Message(string firstName, string lastName)
		{
			LastName = lastName;
			FirstName = firstName;
		}

		#region IMessage Members
		private string _lastName;
		public string LastName
		{
			get
			{
				return (_lastName);
			}
			set
			{
				if (value == null)
				{
					_lastName = "";
				}
				else
				{
					_lastName = value.Trim();
				}
			}
		}

		private string _firstName;
		public string FirstName
		{
			get
			{
				return (_firstName);
			}
			set
			{
				if (value == null)
				{
					_firstName = "";
				}
				else
				{
					_firstName = value.Trim();
				}
			}
		}
		#endregion

		public override string ToString()
		{
			return ((FirstName + " " + LastName).Trim());
		}
	}
}
