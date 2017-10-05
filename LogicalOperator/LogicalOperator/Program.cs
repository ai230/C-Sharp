using System;

namespace LogicalOperator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b);//false
            Console.WriteLine(a || b);//true
            Console.WriteLine(!b);//true

            //Bitwise operator
            ushort a1 = 3;             //00000000 00000011 = 3
            ushort b1 = 5;             //00000000 00000101 = 5
            Console.WriteLine(a1 | b1);//00000000 00000111 = 7

            //Left Shift
            Console.WriteLine(a1 << 1);//00000000 00000110 = 6
			Console.WriteLine(a1 << 2);//00000000 00001100 = 12
			
            //Right shift
            Console.WriteLine(a1 >> 1);//00000000 00000001 = 1
			Console.WriteLine(a1 >> 2);//00000000 00000000 = 0

			Console.Read();
        }
    }
}
