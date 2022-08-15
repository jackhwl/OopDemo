using System;
namespace Calendar
{
	public class YearDate
	{
		private int _month;
		private int _day;
		private Calendar _calendar;

		public YearDate(int month, int day, Calendar calendar)
		{
			_month = month;
			_day = day;
			_calendar = calendar;
		}


		public YearDate GetNext() =>
			IsEndOfMonth() ? new YearDate(_calendar.NextMonth(_month), 1, _calendar) : new YearDate(_month, _day + 1, _calendar);

		public bool IsBefore(YearDate other) =>
			_month < other._month || (_month == other._month && _day < other._day);

        private bool IsEndOfMonth() => _day == _calendar.DaysInMonth(_month);

		public override string ToString() => _month + "/" + _day;

        public override bool Equals(object obj)
        {
			YearDate day = obj as YearDate;

			if (day == null) return false;

            return _month == day._month && _day == day._day;
        }

        public override int GetHashCode() => (_month, _day).GetHashCode();
    }
}

