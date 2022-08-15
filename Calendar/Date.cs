using System;
namespace Calendar
{
	public class Date
	{
		private int _year;
		private YearDate _day;
		private Calendar _calendar;

		public Date(int year, YearDate day, Calendar calendar)
		{
			_year = year;
			_day = day;
			_calendar = calendar;
		}

		public Date GetFirstOccurrence(YearDate day) =>
			GetFirstDayOccurrence(day.IsBefore(_day) ? _year + 1 : _year, day);

		private Date GetFirstDayOccurrence(int year, YearDate day) =>
			new Date(day.IsLeap() ? GetLeap(year) : year, day, _calendar);

		public Date GetFirstDayOccurrence(Date day) => GetFirstDayOccurrence(_year, day._day);

        private int GetLeap(int year) => _calendar.IsLeapYear(year) ? year : GetLeap(year + 1);

        public Date AddYears(int count) => FirstValidDate(_year + count, _day);

		private Date FirstValidDate(int year, YearDate day) => day.IsLeap() && !_calendar.IsLeapYear(year)
			? new Date(year, day.GetNext(), _calendar) : new Date(year, day, _calendar);

		//private bool IsLeap(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        public override string ToString() => _day + "/" + _year;
    }
}

