using System;
namespace Calendar
{
	public class Date
	{
		private int _year;
		private YearDate _day;

		public Date(int year, YearDate day)
		{
			_year = year;
			_day = day;
		}

		public Date GetFirstOccurrence(YearDate cutoff)
        {
			return new Date(_year, cutoff);
        }

		public Date AddYears(int count) => FirstValidDate(_year + count, _day);

		private Date FirstValidDate(int year, YearDate day) => day.IsLeap() && !IsLeap(year)
			? new Date(year, day.GetNext()) : new Date(year, _day);

		private bool IsLeap(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        public override string ToString() => _day + "/" + _year;
    }
}

