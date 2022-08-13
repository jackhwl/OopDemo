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
            SchoolSystem school = new SchoolSystem(new YearDate(3, 1), 5, new YearDate(8, 15));

            Child jack = new Child("Jack", new Date(2016, new YearDate(2, 29)));
            Child jill = new Child("Jill", new Date(2015, new YearDate(8, 27)));


            Report(jack, school);
            Report(jill, school);

            Console.ReadLine();
        }
    }
}

