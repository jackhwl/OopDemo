﻿using System;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Date birthday = new Date(2016, 2, 29);
            Child schoolChild = new Child("Jack", birthday);

            Console.ReadLine();
        }
    }
}
