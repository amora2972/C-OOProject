using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Console_Oop_Project
{
    class Rent
    {
        //attributer or properties
        private int RentID;
        private double total;
        private List<Cars> c = new List<Cars>();
        private double priceperday;

        //constructor 1
        public Rent(Customer c1)
        {
            c = (new Cars()).getCars();


            int duration = c1.Duration;
            int car = c1.ChoosenCar;
            Total = c[car].getTotal(duration, c[car].PricePerDay, c[car].PricePerMonth, c[car].PricePerYear);
            priceperday = Total / duration;
            printBill(c1);
            Console.WriteLine("Do you approve?y or n");
            char check = Convert.ToChar(Console.ReadLine());
            if(check == 'y')
            {
                StoreToDatabase(c1, car, duration);
            }
            else
            {
                Console.WriteLine("Your operation is cancelled");
            }
        }

        //get and set for my id attribute
        public int rentID{
            get
            {
                return this.rentID;
            }
            set
            {
                this.RentID = value;
            }
        }

        //get and set for my total attribute
        public double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }

        public void printBill(Customer c1)
        {
            Console.WriteLine();
            Console.WriteLine("--------------------------------------bill------------------------------------------");
            Console.WriteLine("ID\tName\t\t\tAge\tCar\t\t\tDuration\tpriceperday");
            Console.WriteLine(c1.CustomerID + "\t" + c1.Name + "\t\t" + c1.Age + "\t" + c[c1.ChoosenCar].CarName + "\t\t" + c1.Duration + "\t\t" + priceperday);
            Console.WriteLine("total is: " + Total);
        }

        public void StoreToDatabase(Customer c1, int car, int duration)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/For_Backup/UniversitySubjects/university_docs/thirdYear/First_Semester/C#/MhdOmarBahra_B1605.090065_OopProject/Console_Oop_Project/bin/Debug/Cars.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO RentedCars VALUES('" + c1.CustomerID + "','" + c1.Name + "','" + c1.Age + "','" + c[car].CarName + "','" + c[car].CarModel + "','" + duration + "','" + Total + "')";
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result > 0)
            {
                Console.WriteLine("Inserted");
            }
            else
            {
                Console.WriteLine("Three are errors. The record was not inserted.");
            }
        }
    }
}
