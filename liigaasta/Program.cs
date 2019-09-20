using System;

namespace liigaasta
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int yearOfBirth;
             //liigaasta - aastaarv jagub 4ga//


             Console.WriteLine("Please enter your year of birth: ");
             yearOfBirth = Int32.Parse(Console.ReadLine());


              if (yearOfBirth % 4 == 0)
              {
                  Console.WriteLine("Liigaasta");
              }
              else
                  Console.WriteLine("Ei ole liigaasta");*/


            //Ternary operator - töötab vaid siis kui on kaks võimalust//
            /*string answer = (yearOfBirth % 4 == 0) ? "Liigaasta." : "Ei ole liigaasta";
            Console.WriteLine(answer);*/

            
            
            
            Console.WriteLine("Choose your poison, whisky or wine");
            string drink = Console.ReadLine();
            

            string answer = drink == "wine" ? "Here's your wine" : "Here's your whisky";
            Console.WriteLine(answer);


            Console.ReadLine();


        }
    }
}
