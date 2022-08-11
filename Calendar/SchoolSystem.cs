using System;
namespace Calendar
{
	public class SchoolSystem
	{
		private YearDate _cutoff;
		private int _minAge;
		private YearDate _schoolStart;

		public SchoolSystem(YearDate cutoff, int minAge, YearDate schoolStart)
		{
			_cutoff = cutoff;
			_minAge = minAge;
			_schoolStart = schoolStart;
		}
	}
}

