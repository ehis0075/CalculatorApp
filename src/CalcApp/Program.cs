using System;

namespace CalcApp
{
    class Program
    {
       
        static void Main(string[] args)
        {

        int a, b, c;
        ConsoleKeyInfo status;

         while(true)
         {
             
            Console.WriteLine("Welcome to my Calculator Application");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Press any following key to perform an arithmetric operation:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            Console.Write("Enter Choice(1-4):");
            int answer = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the first number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number:");
            b = Convert.ToInt32(Console.ReadLine());
         
            switch(answer)
            {
                case 1:
                    
                    c = a + b;
                    Console.WriteLine("The Sum of the two numbers is = {0}", c);
                    break;
                case 2:
                   
                    c = a - b;
                    Console.WriteLine("The Difference between the two numbers is = {0}", c);
                    break;
                case 3:
                    
                    c = a * b;
                    Console.WriteLine("The Product of the two numbers is = {0}", c);
                    break;
                case 4:
                   
                    c = a / b;
                    Console.WriteLine("The Quotient of the two numbers is = {0}", c);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
           
            Console.WriteLine("\nDo you want to continue again (Y/N)?");
            status = Console.ReadKey();
            if (status.Key == ConsoleKey.Y)
            {
                break;
            }
            Console.Clear();

         }

        }
    }
}
