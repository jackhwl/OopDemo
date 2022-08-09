using System;

namespace OopDemo
{
    class SchoolCalendar
    {
        private int beginMonth;
        private int beginDay;
        private int minAge;

        public SchoolCalendar(int month, int day, int age)
        {
            beginMonth = month;
            beginDay = day;
            minAge = age;
        }

        public virtual bool IsLeap(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }

        public int GetSchoolDate(int birthday)
        {
            int year = birthday / 10000 + minAge;
            int month = (birthday % 10000) / 100;
            int day = (birthday % 10000) % 100;

            if (month > beginMonth || (month == beginMonth && day > beginDay) )
            {
                year++;
            }

            return year * 10000 + beginMonth * 100 + beginDay;
        }

        public int GetSchoolBirthday(int birthday)
        {
            int month = (birthday % 10000) / 100;
            int day = (birthday % 10000) % 100;

            int firstSchoolDay = GetSchoolDate(birthday);

            int year = firstSchoolDay / 10000;

            if (month < beginMonth || (month == beginMonth && day < beginDay))
            {
                year++;
            }

            while (month == 2 && day == 29 && !IsLeap(year))
            {
                year++;
            }

            return year * 10000 + birthday % 10000;
        }

    }

    class JulianSchoolCalendar : SchoolCalendar
    {
        public JulianSchoolCalendar(int month, int day, int age) : base(month, day, age)
        {
             
        }

        public override bool IsLeap(int year)
        {
            return year % 4 == 0;
        }
    }

    class Program
    {
        //Implement Main method to try these methods out
        static void Main(string[] args)
        {
            int birthday = 18920229;
            var sc = new SchoolCalendar(9, 1, 6);
            int firstSchoolDay = sc.GetSchoolDate(birthday);
            int firstBirthDay = sc.GetSchoolBirthday(birthday);

            Console.WriteLine("kid's birthday:" + birthday);
            Console.WriteLine("first day at school:" + firstSchoolDay);
            Console.WriteLine("first birthday at school:" + firstBirthDay);

            Console.WriteLine();

            SchoolCalendar jsc = new JulianSchoolCalendar(9, 1, 6);
            int jfirstSchoolDay = jsc.GetSchoolDate(birthday);
            int jfirstBirthDay = jsc.GetSchoolBirthday(birthday);

            Console.WriteLine("j kid's birthday:" + birthday);
            Console.WriteLine("j first day at school:" + jfirstSchoolDay);
            Console.WriteLine("j first birthday at school:" + jfirstBirthDay);

        }
    }
}

