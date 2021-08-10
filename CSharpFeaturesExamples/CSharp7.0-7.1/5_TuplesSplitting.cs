using System;

namespace CSharpFeaturesExamples.CSharp7._0_7._1
{
    public class TuplesSplitting
    {
        public static void Run()
        {
            (string Name, double Salary, string Gender, string Dept) = GetEmployeeDetails(1001);
            // Do something with the data.
            //here we are just printing the data in the console
            Console.WriteLine("Employee Details :");
            Console.WriteLine($"Name: {Name},  Gender: {Gender}, Department: {Dept}, Salary:{Salary}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private static (string, double, string, string) GetEmployeeDetails(long EmployeeID)
        {
            //based on the EmployyeID get the data from a database
            //here we are hardcoded the value
            string EmployeeName = "Pranaya";
            double Salary = 2000;
            string Gender = "Male";
            string Department = "IT";
            return (EmployeeName, Salary, Gender, Department);
        }
    }
}
