using System;
using System.Collections.Generic;

namespace Sorting
{
    class MainClass
    {
        private class StudentComparator : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                string lastname1 = x.Substring(x.IndexOf(" ") + 1);
                string lastname2 = y.Substring(y.IndexOf(" ") + 1);

                return 

            }
        }
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 10, 11, 12 };
            Console.WriteLine("Numbers sorted be module 6");
            Array.Sort(numbers, (x, y) => (x % 6).CompareTo(y % 6));
            Console.WriteLine("output ");
            foreach(int no in numbers)
            {
                Console.Write("{0}\t",no);
            }


            //Sorting by last name
            string[] name = { "Doncho aaa", "ddd kkk"};
            Console.WriteLine("students sorted by first letter of the");
            Array.Sort(students, new StudentComparator());
            foreach(var )
            Console.WriteLine("Hello World!");
        }
    }
}
