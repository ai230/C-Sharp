using System;

namespace Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //1)
            Console.WriteLine("1)--------------------------");
            int m = 5;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write(j+1);
				}
				Console.WriteLine();
			}
            Console.WriteLine();
            //2)
            Console.WriteLine("2)--------------------------");
            Console.WriteLine("Input the size of the square matrix (less than 5) : ");
            int inputNum2 = int.Parse(Console.ReadLine());
            int size = inputNum2;
            int[,] matrix1 = new int[ size, size ];
            int[,] matrix2 = new int[ size, size ];
            for (int a = 0; a < 2; a++)
            {
				if (a == 0)
				{
					Console.WriteLine("Input elements in the first matrix :");
				}
				else
				{
					Console.WriteLine("Input elements in the second matrix :");
				}
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        
                        Console.Write("Matrix[{0},{1}] = ", i, j);
                        int element = int.Parse(Console.ReadLine());
                        if (a == 0)
                        {
                            matrix1[i, j] = element;
                        }
                        else
                        {
                            matrix2[i, j] = element;
                        }
                    }
                }
            }

			for (int a = 0; a < 2; a++)
			{
				if (a == 0)
				{
					Console.WriteLine("The First matrix is:");
				}
				else
				{
					Console.WriteLine("The Second matrix is :");
				}
				for (int i = 0; i < size; i++)
				{
					for (int j = 0; j < size; j++)
					{
                        if(a == 0)
                        {
                            Console.Write("{0} ", matrix1[i, j]);
                        }
                        else
                        {
                            Console.Write("{0} ", matrix2[i, j]);
                        }
					}
                    Console.WriteLine();
				}
			}

			//addition
			int[,] matrix3 = new int[size, size];
            Console.WriteLine("The Addition of two matrix is :");
            for (int i1 = 0; i1 < inputNum2; i1++)
            {
				for (int j1 = 0; j1 < inputNum2; j1++)
				{
					int ele1 = matrix1[i1, j1];
					int ele2 = matrix2[i1, j1];
					matrix3[i1, j1] = ele1 + ele2;
                    Console.Write("{0} ", matrix3[i1, j1]);
				} 
                Console.WriteLine();
            }

            Console.WriteLine();
            //3)
            Console.WriteLine("3)--------------------------");
            int inputNum;
            Console.Write("Enter a number : ");
            inputNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The Fibonacci of {0} th term is {1}", inputNum, calFibonacci(inputNum));

            Console.ReadLine();
        }

        public static int calFibonacci(int num)
        {
            if(num <= 2)
            {
                return 1;
            }
            else
            {
                return calFibonacci(num - 1) + calFibonacci(num - 2);
            }
        }

    }
}
