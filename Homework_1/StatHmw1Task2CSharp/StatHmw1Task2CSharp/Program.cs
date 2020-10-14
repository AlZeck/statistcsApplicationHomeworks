using System;

namespace StatHmw1Task2CSharp
{
    class MyRefInt
    {
        public int i; 
        public MyRefInt(int i)
        {
            this.i = i;
        }
    }
    struct MyValInt
    {
        public int i; 
        public MyValInt(int i)
        {
            this.i = i;
        }
    }

    class Program
    {
        public static void Add10AndPrintRef(MyRefInt curr)
        {
            Console.WriteLine("Checking the value before the operation: " + curr.i);
            curr.i += 10;            
            Console.WriteLine("Checking the value after the operation: "+ curr.i);
        }

        public static void Add10AndPrintVal(MyValInt curr)
        {
            Console.WriteLine("Checking the value before the operation: " + curr.i);
            curr.i += 10;
            Console.WriteLine("Checking the value after the operation: " + curr.i);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Creating 2 variables containing the same integer");
            
            MyValInt value = new MyValInt(10);
            MyRefInt refer = new MyRefInt(10);

            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Calling the function for the reference data type: " + refer.i);
            Add10AndPrintRef(refer);
            Console.WriteLine("Checking the value after the return of the function for the reference data type: " + refer.i);

            Console.WriteLine("----------------------------------------------------------------------------");

            Console.WriteLine("Calling the function for the value data type: " + value.i);
            Add10AndPrintVal(value);
            Console.WriteLine("Checking the value after the return of the function for the value data type: " + value.i);

        }
    }
}
