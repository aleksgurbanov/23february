using System;

namespace Task223February
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IS EVEN METODU");
            Console.WriteLine(ExtentionMethods.IsEven(4));
            
            Console.WriteLine(ExtentionMethods.IsEven(5));
            Console.WriteLine("IS EVEN METODU");
            //////////////////
            Console.WriteLine("IS ODD METODU");
            Console.WriteLine(ExtentionMethods.IsOdd(4));
            Console.WriteLine(ExtentionMethods.IsOdd(3));

            Console.WriteLine("IS ODD METODU");
            ////////////
            Console.WriteLine("REQEM METODUUU");
            Console.WriteLine(ExtentionMethods.IsContainsDigit("salam"));
            Console.WriteLine(ExtentionMethods.IsContainsDigit("55salam"));

            Console.WriteLine("REQEM METODUUU");
            /////////////////////////
            ///Get Value Indexes for integer types



            ////get value indexes for string types
            ///
            string[] arr1 = { "bir", "bizon", "redbul" , "elave" };

            char yoxlayan = 'b';

            foreach (string item in ExtentionMethods.GetValueIndexes(arr1,yoxlayan))
            {
                Console.WriteLine(item);
            }
            

           

        }
    }
}
