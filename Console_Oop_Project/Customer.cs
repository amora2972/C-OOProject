using System;
using System.Collections.Generic;

namespace Console_Oop_Project
{
    class Customer
    {
        private int customerID;
        private string name;
        private int age;
        private int choosenCar;
        private Int32 duration;

        public Customer()
        {
            List<Cars> c = new List<Cars>();
            c = (new Cars()).getCars();
            //my random generator
            Random r1 = new Random();
            //setting a random number for the id of the customer
            CustomerID = r1.Next(1, 10000);

            //getting user input for name
            Console.WriteLine("Enter your full name: ");
            Name = Console.ReadLine();

            //getting user input for age
            Console.WriteLine("Enter your age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            //getting the input of the choosen car
            Console.WriteLine("please enter the number of the car you want to rent: ");
            int counter = 1;
            foreach (var aCar in c)
            {
                Console.WriteLine(counter + "." + aCar.CarName + " " + aCar.CarYear);
                counter++;
            }
            choosenCar = Convert.ToInt32(Console.ReadLine()) - 1;

            //getting for how long does the user need the car
            Console.WriteLine("For how long do you need the car(in days) 365 days = 1 year: ");
            Duration = Convert.ToInt32(Console.ReadLine());

        }

        public int ChoosenCar
        {
            get
            {
                return this.choosenCar;
            }
            set
            {
                this.choosenCar = value;
            }
        }

        public Int32 Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }

        public int CustomerID
        {
            get
            {
                return this.customerID;
            }
            set
            {
                this.customerID = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                while(value < 18)
                {
                    Console.Write("please enter an age that is bigger than 18: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                this.age = value;
            }
        }

        public void print()
        {
            Console.WriteLine(CustomerID + " " + Name + " " + Age);
        }
    }
}
