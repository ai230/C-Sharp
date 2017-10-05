using System;

namespace InterfaceType
{
    interface myInterface //onlly signachar
	{
        void SampleMethod();
    } 

    class Program : myInterface
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Decleare an instance of interface
            myInterface i = new Program();
            i.SampleMethod();
        }

		public void SampleMethod()
		{
			Console.WriteLine("Interface implemented!");
		}

	}

}
