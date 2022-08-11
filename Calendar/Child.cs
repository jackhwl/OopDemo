using System;
namespace Calendar
{
	public class Child
	{
		private string _name;
		private Date _birthday;

		public Child(string name, Date birthday)
		{
			_name = name;
			_birthday = birthday; 
		}

        public override string ToString()
        {
			return _name + " born on " + _birthday;
        }
    }
}

