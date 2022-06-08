using System;

namespace CSharpBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interpolated String
            var name = "Chad";
            Console.WriteLine($"This is a test {name}");

            //WriteLine calls string.Format
            Console.WriteLine("This is another test for {0}", name);

            //Using the string format
            Console.WriteLine(string.Format("This is a test with string.Format for {0}",name));


        }
    }
}
