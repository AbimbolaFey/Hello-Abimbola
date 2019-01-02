using System;

namespace Hello_Abimbola
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName = "";
            int age = 0;
            string location = "";
            int FatherAge = 0;
            int ShoeSize = 0;
            

            Console.Write("Enter Your Name:");
            personName = Console.ReadLine();
            Console.Write("Enter Your Age: ");
            age = Int32.Parse(Console.ReadLine());
            if (age > 60)
            {
                Console.WriteLine("You are so close");
            }
                
            else
            {
                Console.WriteLine("You still have time");
            }


            Console.WriteLine("Enter Your Location: ");
            location = Console.ReadLine();

            Console.WriteLine("Enter Your Father's age: ");
            FatherAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Shoe size: ");
            ShoeSize = Int32.Parse(Console.ReadLine());
            int sum = FatherAge + ShoeSize;
            Console.WriteLine("Your Lucky number is " + sum);



       



            Console.ReadLine();

        }
    }
}
