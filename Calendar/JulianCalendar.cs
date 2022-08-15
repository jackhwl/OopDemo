using System;
namespace Calendars
{
	public class JulianCalendar : Calendar
	{
		public override string GetName() => "Julian";

		public override bool IsLeapYear(int year) => year % 4 == 0;

	}
}

