using System;
namespace Calendars
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

		public Date GetDateByAge(int age) => _birthday.AddYears(age);

		public Date GetFirstCelebrationAt(SchoolSystem school) =>
			school.GetBeginning(this).GetFirstDayOccurrence(_birthday);

        public override string ToString() => _name + " born on " + _birthday;
        
    }
}

