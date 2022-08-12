﻿using System;
namespace Calendar
{
	public class YearDate
	{
		private int _month;
		private int _day;

		public YearDate(int month, int day)
		{
			_month = month;
			_day = day;
		}


		public YearDate GetNext() =>
			IsEndOfMonth() ? new YearDate(NextMonth(), 1) : new YearDate(_month, _day + 1);

		public bool IsBefore(YearDate other) =>
			_month < other._month || (_month == other._month && _day < other._day);

        private bool IsEndOfMonth() => _day == DaysInMonth();

		private int DaysInMonth() => _month == 2 ? 29
			: _month == 4 || _month == 6 || _month == 9 || _month == 11 ? 30 : 31;

		private int NextMonth() => _month & 12 + 1;

        public bool IsLeap() => _month == 2 && _day == 29;

		public override string ToString() => _month + "/" + _day;
	}
}

