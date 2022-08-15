using System;

namespace Calendars
{
    class Program
    {
        static void Report(Child child, SchoolSystem school)
        {
            Console.WriteLine(
                child + " starts school on " + school.GetBeginning(child)
                + " celebration on: " +  child.GetFirstCelebrationAt(school));
        }

        static void Demostrate(Calendar cal)
        {
            SchoolSystem school = new SchoolSystem(new YearDate(cal, 3, 1), 5, new YearDate(cal, 8, 15));

            Child jack = new Child("Jack", cal.Create(1892, 2, 29));
            Child jill = new Child("Jill", cal.Create(1891, 8, 27));

            Console.WriteLine("Using " + cal.GetName() + " calendar:");
            Report(jack, school);
            Report(jill, school);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Demostrate(new GregorianCalendar());
            Demostrate(new JulianCalendar());

            Console.ReadLine();
        }
    }
}

