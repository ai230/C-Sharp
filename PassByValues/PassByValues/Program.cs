using System;

namespace PassingValues
{
    class MainClass
    {
        //accsess modifier return type 
        public void swap(ref int x, ref int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside the swap Method a = {0} b = {1}", x, y);

        }

        public static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("Before a = {0} b = {1}",a,b);
            MainClass m = new MainClass();
            //m.swap(a,b);
            //Console.WriteLine("After1 a = {0} b = {1}", a, b);
            m.swap(ref a, ref b);
            Console.WriteLine("After ref a = {0} b = {1}", a, b);

            Console.Read();
        }
    }
}
