using System;

namespace Calendar
{
    class Program
    {
        static void Report(Child child, SchoolSystem school)
        {
            Console.WriteLine(
                child + " starts school on " + school.GetBeginning(child)
                + " celebration on: " +  child.GetFirstCelebrationAt(school));
        }

        static void Main(string[] args)
        {
            Calendar gCalendar = new GregorianCalendar();
            SchoolSystem school = new SchoolSystem(new YearDate(3, 1, gCalendar), 5, new YearDate(8, 15, gCalendar));

            Child jack = new Child("Jack", new Date(2016, new YearDate(2, 29, gCalendar), gCalendar));
            Child jill = new Child("Jill", new Date(2015, new YearDate(8, 27, gCalendar), gCalendar));


            Report(jack, school);
            Report(jill, school);

            Console.ReadLine();
        }
    }
}

