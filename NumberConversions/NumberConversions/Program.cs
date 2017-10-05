using System;

namespace NumberConversions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numVal = -2;
			//-2,147,483,648 to 2,147,483,647
			Console.WriteLine("Enter a number btw -2,147,483,648 to +2,147,483,647");
            string input = Console.ReadLine();
            try
            {
                numVal = Convert.ToInt32(input); 
            }
            catch(FormatException e)
            {
                Console.WriteLine("INPUT STRING IS NOT A SEQUENCE OF DIGITS " + e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine("NUMBER CAN NOT FIT IN INT32 " + e.Message);
				//When it get overflow return a value btw -2,147,483,648 - your input value
			}
            finally
            {
                //always it is excuting
                if(numVal < Int32.MaxValue)
                {
                    Console.WriteLine("Your new value is {0}", numVal + 1);
                }
                else
                {
                    Console.WriteLine("the number");   
                }
            }

            Console.Read();
        }
    }
}
