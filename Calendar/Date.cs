using System;
namespace Calendars
{
	public class Date
	{
		private int _year;
		private YearDate _day;
		private Calendar _calendar;

		public Date(Calendar calendar, int year, YearDate day)
		{
			_year = year;
			_day = day;
			_calendar = calendar;
		}

		public Date GetFirstOccurrence(YearDate day) =>
			GetFirstDayOccurrence(day.IsBefore(_day) ? _year + 1 : _year, day);

		private Date GetFirstDayOccurrence(int year, YearDate day) =>
			new Date(_calendar, day.IsLeap() ? GetLeap(year) : year, day);

		public Date GetFirstDayOccurrence(Date day) => GetFirstDayOccurrence(_year, day._day);

        private int GetLeap(int year) => _calendar.IsLeapYear(year) ? year : GetLeap(year + 1);

        public Date AddYears(int count) => FirstValidDate(_year + count, _day);

		private Date FirstValidDate(int year, YearDate day) => 
			new Date(_calendar, year, day.IsLeap() && !_calendar.IsLeapYear(year) ? day.GetNext() : day);

        public override string ToString() => _day + "/" + _year;
    }
}

