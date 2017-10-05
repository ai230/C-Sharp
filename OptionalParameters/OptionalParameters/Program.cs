using System;

namespace OptionalParameters
{
    class MainClass
    {

        public void PrintNumber(int start = 0; int end = 20)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write("{0}\t",i);
            }
        }

        public static void Main(string[] args)
        {
         
            Console.WriteLine("Hello World!");
        }
    }
}
