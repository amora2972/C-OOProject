using System;

namespace Console_Oop_Project
{
    class Program
    {
        public static void Main(string[] args)
        {
            int checker = start();
            while (checker != -1)
            {
                while (checker == 1)
                {
                    Customer c1 = new Customer();
                    Rent r1 = new Rent(c1);
                    checker = start();
                }

                while (checker == 0)
                {
                    string id;
                    Console.Write("please enter your ID: ");
                    id = Console.ReadLine();
                    Returning return1 = new Returning(id);
                    checker = start();
                }
            }

            
            
        }
        public static int start()
        {
            Console.WriteLine("Please enter 1 for renting a car and 0 for returning a car and -1 to terminate: ");
            int checker = Convert.ToInt32(Console.ReadLine());
            return checker;
        }
    }
}
