using System;

namespace CSharpFeaturesExamples.CSharp7._0_7._1
{
    public static class OutParameters_Discard
    {
        public static void Run()
        {
            // Department has been discarded via a "_"
            GetEmployeeDetails(out var EmployeeName, out var Gender, out var Salary, out var _);
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {EmployeeName}, Gender: {Gender}, Salary: {Salary}, Department: Not defined");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Ankit R";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }
    }
}
