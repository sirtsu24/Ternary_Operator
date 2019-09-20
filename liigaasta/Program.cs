using System;

namespace liigaasta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int yearOfBirth;
            //liigaasta - aastaarv jagub 4ga//
            int y = 4;
            
            Console.WriteLine("Please enter your year of birth: ");
            yearOfBirth = Int32.Parse(Console.ReadLine());
            int x = yearOfBirth;
            Console.WriteLine(yearOfBirth % y);


            if (x % y == 0)
            {
                Console.WriteLine("Liigaasta");
            }
            else
                Console.WriteLine("Ei ole liigaasta");
            Console.ReadLine();


        }
    }
}
