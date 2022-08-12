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

		public Date GetDateByAge(int minAge)
        {
			return _birthday.GetNext(minAge); // new Date(_birthday.Year + minAge, _birthday.Day);
        }

        public override string ToString()
        {
			return _name + " born on " + _birthday;
        }
    }
}

