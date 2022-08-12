using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(2016, new YearDate(2, 29));
            Child schoolChild = new Child("Jack", birthday);

            SchoolSystem school = new SchoolSystem(new YearDate(3, 1), 5, new YearDate(8, 15));
            Date schoolStart = school.GetBeginning(schoolChild);

            Console.WriteLine(birthday);
            Console.WriteLine(schoolChild);
            Console.WriteLine(schoolStart);
            Console.ReadLine();
        }
    }
}

