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

        //Implement method which calculates first day at school, given the birthdate
        public int GetFirstSchoolDayAtSchool(int birthday)
        {
            int year = birthday / 10000;
            int month = (birthday % 10000) / 100;
            int day = (birthday % 10000) % 100;

            int firstYear = year + minAge;

            if (month > beginMonth || (month == beginMonth && day > beginDay) )
            {
                firstYear++;
            }

            return firstYear * 10000 + beginMonth * 100 + beginDay;
        }

        //Implement method which calculates child's first birthday at school
        public int GetFirstBirthDayAtSchool(int birthday)
        {
            int year = birthday / 10000;
            int month = (birthday % 10000) / 100;
            int day = (birthday % 10000) % 100;

            int firstSchoolDay = GetFirstSchoolDayAtSchool(birthday);

            int firstYear = firstSchoolDay / 10000;

            if (month < beginMonth || (month == beginMonth && day < beginDay))
            {
                firstYear++;
            }

            while (month == 2 && day == 29 && firstYear % 4 != 0 && firstYear % 400 != 0)
            {
                firstYear++;
            }

            return firstYear * 10000 + birthday % 10000;
        }

    }



    class Program
    {
        //Implement Main method to try these methods out
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int birthday = 19910229;
            var sc = new SchoolCalendar(9, 1, 6);
            int firstSchoolDay = sc.GetFirstSchoolDayAtSchool(birthday);
            int firstBirthDay = sc.GetFirstBirthDayAtSchool(birthday);

            Console.WriteLine("birthday:" + birthday);
            Console.WriteLine("first day at school:" + firstSchoolDay);
            Console.WriteLine("first birthday at school:" + firstBirthDay);
        }
    }
}

