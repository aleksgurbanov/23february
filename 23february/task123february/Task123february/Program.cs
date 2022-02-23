using System;

namespace Task123february
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ad ve soyad daxil et!");
            string adsoyad = Console.ReadLine();

            Console.WriteLine("group n daxil et");
            string qrup = Console.ReadLine();

            Console.WriteLine("yash daxil et");
            string yash = Console.ReadLine();
            int yash1 = int.Parse(yash);
            Students student = new Students(adsoyad, qrup, yash1);
            
        }
    }
}
