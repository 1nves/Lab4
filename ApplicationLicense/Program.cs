using System;
using System.Text;


namespace ApplicationLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            Console.Write("Enter the key= ");
            string key = Console.ReadLine();

            var license = new License(key);
            license.Print();
           
            
            Console.ReadLine();
        }
    }
}
 
