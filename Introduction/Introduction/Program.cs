using System;

namespace Introduction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            decimal d = 0.2m;


            //formatted into Currency format string
            decimal x = 0.999m;
            decimal z = 999999999m;
            Console.WriteLine("x = {0:C}", x);
            Console.WriteLine("z = {0:C}", z);


            double d1 = 2D;
            double d2 = 1.76E+10;
            Console.WriteLine("d1 = {0} d2 = {1}", d1, d2);
            Console.WriteLine(d2);

            float pi = 3.14149265f;
            Console.WriteLine("Value pi = {0}", pi);

            double a = 1.0f;
            double b = 0.33f;
            double sum = a + b;
            bool boo = (a +b == sum);
            Console.WriteLine("(a + b == sum) is {0}", boo);

            byte centuries = 20;
            uint year = 2017;
            uint day = 730480;

            Object objectA = "Hello";
            Object objectB = "He";
            objectB = objectB + "llo";
            Console.WriteLine("A = B is {0}", objectA == objectB);



            Console.Read();
        }
    }
}
