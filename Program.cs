using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            EmpWageCalculator empWageCalculator = new EmpWageCalculator();

            //Add the details of all the companies first
            //Add the details of all the companyList first
            empWageCalculator.AddCompanyDetails("Reliance", 60, 20, 100);
            empWageCalculator.AddCompanyDetails("Flipkart", 40, 20, 80);

            // Calculate the employee wage of all the companies
            // Calculate the employee wage of all the companyList
            empWageCalculator.CalculateTotalEmpWage();

            empWageCalculator.GetWagesOfCompany("Reliance");

        }


    }
}