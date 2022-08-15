using System;
namespace Calendar
{
	public class Calendar
	{
		public virtual bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

		public virtual bool IsLeapDay(YearDate day) => day.IsLeap();

		public virtual int DaysInMonth(int month) => month == 2 ? 29 : month == 4 || month == 6 || month == 9 || month == 11 ? 30 : 31;

		public virtual int NextMonth(int month) => month % 12 + 1;
	}
}

