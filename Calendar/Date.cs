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

		public Date GetNext(int year)
        {
			return new Date(_year + year, _day);
        }

        public override string ToString()
        {
			return _day + "/" + _year;
        }
    }
}

