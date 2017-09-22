using System;

namespace Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
		
		//1)
		Console.WriteLine("(1)----------------------");
            Console.WriteLine("Hello");
            Console.WriteLine("Ai Yamamoto");

		//2)
		Console.WriteLine("(2)----------------------");
            Console.WriteLine("Enter two numbers");
            Console.Write("First number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second number : ");
		int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
			
		//3)
		Console.WriteLine("(3)----------------------");
            Console.WriteLine("Enter Celsius degrees");
            double celsius = double.Parse(Console.ReadLine());
            double kelvin = celsius + 273;
            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("Celsius : {0} Kelvin : {1} Fahrenheit : {2} ", celsius, kelvin, fahrenheit);
			
            //4)
            Console.WriteLine("(4)----------------------");
            Console.WriteLine("Enter three letters");
            char l1 = char.Parse(Console.ReadLine());
            char l2 = char.Parse(Console.ReadLine());
            char l3 = char.Parse(Console.ReadLine());
            Console.WriteLine("{0}, {1}, {2}", l3, l2, l1);
			
            //5) vowel(a e i o u) or digit or any other symble
            Console.WriteLine("(5)----------------------");
            Console.WriteLine("Enter a character");
            char c1 = char.Parse(Console.ReadLine());
            string str1 = c1.ToString().ToLower();
            int number;
            if(Int32.TryParse(c1.ToString(), out number))
            {
                Console.WriteLine("Input character is a digit");
            }
            else if (str1 == "a" || str1 == "e" || str1 == "i" || str1 == "o" || str1 == "u")
		{
			Console.WriteLine("Input character is a vowel");
		}
            else
            {
                Console.WriteLine("Input character is any other symbol");
            }

			
            //6)
            Console.WriteLine("(6)----------------------");
		Console.WriteLine("Enter a number");
		int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Input number is even number");
            }
            else
            {
                Console.WriteLine("Input number is odd number");
            }
			
		//7)
		Console.WriteLine("(7)----------------------");
		Console.WriteLine("Enter height of a person in centimeter");
            double height = double.Parse(Console.ReadLine());
            string categorize;
            if(height < 150)
            {
                categorize = "Dwarf";
            }
            else if (150 <= height && height < 165 )
		{
                categorize = "Average Height";
		}
            else if (165 <= height &&  height < 195)
		{
                categorize = "Taller";
		}
            else
            {
                categorize = "Abnormal Height";
            }
            Console.WriteLine("Person's height is {0}cm, categorize is {1}", height, categorize);

			
		//8)ax^2 + bx + c = 0,
            Console.WriteLine("(8)----------------------");
		Console.WriteLine("Enter a, b, c");
            Console.WriteLine("ax2 + bx + c = 0, where a, b and c are real numbers and a ≠ 0.");

            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            //Console.WriteLine();
		Console.Write("b = ");
		int b = int.Parse(Console.ReadLine());
		//Console.WriteLine();
		Console.Write("c = ");
		int c = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}x2 + {1}x + {2} = 0", a, b, c);

		float d;
            double root1, root2;

            d = b * b - 4 * a * c; 

            if(d > 0)
            {
                Console.WriteLine("Determinant is greater than 0, The roots are real and different.");
                root1 = (-b + Math.Sqrt(d)) / (2 * a);
                root2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Solutions are {0:F2} and {1:F2}", root1, root2);

            }
            else if(d == 0.000000000)
            {
				Console.WriteLine("Determinant is equal to 0, The roots are real and equal.");
				root1 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Solutions are {0:F2}", root1);

            }
            else if(d < 0)
            {
                Console.WriteLine("Determinant is less than 0, The roots are complex and different.");
                root1 = -b / (double)(2 * a);
				root2 = Math.Sqrt(-d) / (2 * a);
                Console.WriteLine("Solutions are {0:F2} + {1:F2}i or {2:F2} + {3:F2}i", root1, root2, root1, root2);
            }
            //9)
			Console.WriteLine("(9)----------------------");

            int choice = 0;
            int firstInt = 0;
            int secondInt = 0;
            while(choice != 5)
            {
		Console.WriteLine("=============================");
		Console.WriteLine("1-Addition.");
		Console.WriteLine("2-Substraction");
		Console.WriteLine("3-Multiplication");
		Console.WriteLine("4-Divition");
		Console.WriteLine("5-Exit.");
		Console.WriteLine("=============================");
                Console.WriteLine("Enter option number : ");
		choice = int.Parse(Console.ReadLine());
                if(choice != 5)
                {
			Console.Write("Enter the first Integer : ");
			firstInt = int.Parse(Console.ReadLine());
			Console.Write("Enter the second Integer : ");
			secondInt = int.Parse(Console.ReadLine());
			Console.WriteLine("");
                }
		switch(choice)
                {
                    case 1:
                        Console.WriteLine("{0} + {1} = {2}", firstInt, secondInt, firstInt + secondInt);
                        break;
                    case 2:
                        Console.WriteLine("{0} - {1} = {2}", firstInt, secondInt, firstInt - secondInt);
                        break;
                    case 3:
                        Console.WriteLine("{0} x {1} = {2}", firstInt, secondInt, firstInt * secondInt);
                        break;
                    case 4:
                        Console.WriteLine("{0} / {1} = {2}", firstInt, secondInt, firstInt / secondInt);
                        break;
                    case 5:
                        Console.WriteLine("Exit");
                        break;
                }
            }
			
		//10)
		Console.WriteLine("(10)----------------------");
            DateTime date = new DateTime(2017, 9, 12);
            Console.WriteLine(date.ToString("yyy-MM-dd"));
            Console.WriteLine(date.ToString("dd-MMM-yy"));
            Console.WriteLine(date.ToString("M/d/yyy").Replace('-', '/'));
            Console.WriteLine(date.ToString("M/d/yy").Replace('-', '/'));
            Console.WriteLine(date.ToString("MM/dd/yyy").Replace('-', '/'));
            Console.WriteLine(date.ToString("MM/dd/yy").Replace('-', '/'));
            Console.WriteLine(date.ToString("yy/MM/dd").Replace('-', '/'));

		Console.Read();
        }
       
    }
}
