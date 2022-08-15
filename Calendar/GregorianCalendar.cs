using System;
namespace Calendars
{
	public class GregorianCalendar : Calendar
	{
        public override string GetName() => "Gregorian";

		public override bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);


	}
}

