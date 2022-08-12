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

		public Date GetDateByAge(int minAge) => _birthday.AddYears(minAge);

        public override string ToString() => _name + " born on " + _birthday;
        
    }
}

