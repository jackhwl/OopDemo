using System;
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

        public override string ToString()
        {
			return _month + "/" + _day;
        }

        //public bool Early(YearDate yd)
        //{
        //    return yd._month > _month || 
        //}
    }
}

