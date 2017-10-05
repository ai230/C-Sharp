using System;

namespace Loops
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("i = 1 to 50");
            int i = 1;
            while (i <= 50)
            {
                Console.Write("\t{0}",i);
                i++;
            }

            Console.WriteLine("j = 1 to 50");
            int j = 1;
            do
            {
                Console.Write("\t{0}", j);
                j++;
            }
            while (i <= 50);


            /*Factorial 2! = 2 * 1 = 2
             *Factorial 3! = 3 * 2 * 1 = 6*/
            Console.WriteLine("");
            int n = 20;
			// change to decimal from int so it's gonna be bigger than int max 
			decimal factorial = 1;
            for (int k = n; k >= 1; k--)
            {
                factorial = factorial * k;
            }
            Console.Write("{0}! * {1}", n, factorial);

            //Variable of for loop
            // For-each loop
            Console.WriteLine("");
            string[] dayName = new string[]
            {
                "MANDAY","TUSEDAY","FRIDAY"
            };

            foreach(string day in dayName)
            {
                Console.WriteLine(day);
            }


			Console.Read();
        }
    }
}
