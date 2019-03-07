using System;
using System.Data.OleDb;

namespace Console_Oop_Project
{
    class Returning
    {
        public Returning(string ID)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:/For_Backup/UniversitySubjects/university_docs/thirdYear/First_Semester/C#/MhdOmarBahra_B1605.090065_OopProject/Console_Oop_Project/bin/Debug/Cars.mdb";
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE from RentedCars where ID=" + ID;
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result > 0)
            {
                Console.WriteLine("You car is returned.");
            }
            else
            {
                Console.WriteLine("Rent is not existed.");
            }
            Program p = new Program();
        }
    }
}
