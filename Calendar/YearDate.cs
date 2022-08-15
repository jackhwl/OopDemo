﻿using System;
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

        public bool IsLeap() => _month == 2 && _day == 29;

		public override string ToString() => _month + "/" + _day;
	}
}

