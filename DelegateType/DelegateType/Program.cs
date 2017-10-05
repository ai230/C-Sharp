using System;

namespace DelegateType
{
    //Decalre a delegate outside class
    delegate double MainAction(double num);

    class Program
    {
        //create a method that matches signature of delegate
        static double Multiplication(Double input)
        {
            return input * 2;
        }

        static void Main(string[] args)
        {
            //Create an instance for delegate with named method
            MainAction m1 = Multiplication;

            //invoke the delegate instance
            double ans = m1(4.5);
            Console.WriteLine(ans);

            //Create a second instance and performes square
            MainAction m2 = delegate (double input)
            {
                return input * input;
            };
            double square = m2(5.375);
            Console.WriteLine(square);

            MainAction m3 = s => s * s * s;
            double cube = m3(3.222);
            Console.WriteLine(cube);

            Console.WriteLine("Hello World!");
        }
    }
}
