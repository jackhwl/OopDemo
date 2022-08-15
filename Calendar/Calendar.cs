using System;
namespace Calendar
{
	public class Calendar
	{
		public virtual bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

		//public bool IsLeapDay(YearDate day) => day.month == 2 && _day == 29;

	}
}

