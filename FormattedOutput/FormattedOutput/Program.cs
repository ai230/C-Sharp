using System;

namespace FormattedOutput
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            double someVar = 1.234;//01.2340000
			Console.WriteLine("{0:00.0000000}",someVar);

            float pi = 3.14509296f;//3.15
            Console.WriteLine("{0:F2}", pi);

            //Hexadecimal : X
            Console.WriteLine("{0:X}",250);//FA

            //Sorting formatting with left or right arign
            double colaPrice = 1.294;
            string cola = "Coca cola";

			double fantaPrice = 1.203;
			string fanta = "Fanta Dizzy";

			double pepciPrice = 1.592;
			string pepci = "PEPCI";

            Console.WriteLine("-------------------------");
            //-:left align. +: right align
            //15:space
            Console.WriteLine("{0,-15} | {1,15:F2}", cola, colaPrice);
            Console.WriteLine("{0,-15} | {1,15:F2}", fanta, fantaPrice);
            Console.WriteLine("{0,-15} | {1,15:F2}", pepci, pepciPrice);
			Console.WriteLine("-------------------------");


			Console.Write("a= ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.Write("b= ");
			float b = float.Parse(Console.ReadLine());
			Console.WriteLine();
			Console.Write("a= ");
			double c = double.Parse(Console.ReadLine());
			Console.WriteLine();

			Console.WriteLine("a = {0} b = {1} c = {2} ", a, b, c);

            Console.Read();
        }
    }
}
